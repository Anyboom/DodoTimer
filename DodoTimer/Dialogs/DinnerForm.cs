using DodoTimer.Models;
using DodoTimer.Services;

using LiteDB;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DodoTimer
{
    public partial class DinnerForm : Form
    {
        private DataTable mainTable;
        private Person currentPerson;

        internal DinnerForm(int personId)
        {
            InitializeComponent();

            mainTable = new DataTable();

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                currentPerson = db.GetCollection<Person>().FindById(personId);
            }

            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Начало", typeof(TimeSpan));
            mainTable.Columns.Add("Конец", typeof(TimeSpan));

            MainGrid.DataSource = mainTable;

            ContextMenuStrip mainMenu = new ContextMenuStrip();
            
            ToolStripMenuItem refreshDinners = new ToolStripMenuItem("Обновить");
            ToolStripMenuItem startDinner = new ToolStripMenuItem("Записать начальное время на обед");
            ToolStripMenuItem finishDinner = new ToolStripMenuItem("Записать конечное время на обед");

            refreshDinners.Click += (sendor, e) => RefreshDinners();
            startDinner.Click += (sendor, e) => StartDinner();
            finishDinner.Click += (sendor, e) => FinishDinner();

            mainDatePicker.ValueChanged += (sender, e) =>
            {
                RefreshDinners();
                RefreshValues();
            };

            this.Shown += (sender, e) =>
            {
                MainGrid.Columns[0].Visible = false;
            };

            mainMenu.Items.Add(startDinner);
            mainMenu.Items.Add(finishDinner);
            mainMenu.Items.Add(new ToolStripSeparator());
            mainMenu.Items.Add(refreshDinners);

            MainGrid.ContextMenuStrip = mainMenu;

            RefreshDinners();
            RefreshValues();

            MainGroupBox.Text = $"{currentPerson.FirstName} {currentPerson.LastName}";
        }

        private void FinishDinner()
        {
            if (DateTime.Now.Day != mainDatePicker.Value.Day || DateTime.Now.Year != mainDatePicker.Value.Year)
            {
                MessageService.ShowInfo("Можно взаимодействовать с обедами только в нынешний день.");

                return;
            }

            if (MainGrid.SelectedRows.Count == 0)
            {
                return;
            }

            int id = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Dinner>();

                Dinner temp = col.FindById(id);

                if(temp.EndAt != null)
                {
                    return;
                }

                DateTime dateTimeNow = DateTime.Now;

                temp.EndAt = dateTimeNow.AddSeconds(-dateTimeNow.Second);

                col.Update(temp);

                currentPerson.Dinners.Add(temp);

                MainGrid.SelectedRows[0].Cells[2].Value = temp.EndAt?.ToString("HH:mm");

                RefreshValues();
            }

        }

        private void StartDinner()
        {
            if(DateTime.Now.Day != mainDatePicker.Value.Day || DateTime.Now.Year != mainDatePicker.Value.Year)
            {
                MessageService.ShowInfo("Можно взаимодействовать с обедами только в нынешний день.");

                return;
            }

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Dinner>();

                DateTime dateTimeNow = DateTime.Now;

                Dinner temp = new Dinner()
                {
                    StartAt = dateTimeNow.AddSeconds(-dateTimeNow.Second),
                    PersonId = currentPerson.Id
                };

                temp.Id = (int) col.Insert(temp).RawValue;

                mainTable.Rows.Add(temp.Id, temp.StartAt.ToString("HH:mm"), null);
            }
        }

        private void RefreshDinners()
        {
            mainTable.Clear();

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                //db.GetCollection<Dinner>().DeleteAll();
                currentPerson.Dinners = db.GetCollection<Dinner>().Find(x => x.PersonId == currentPerson.Id && x.StartAt.Day == mainDatePicker.Value.Day && x.StartAt.Year == mainDatePicker.Value.Year).ToList();
            }

            foreach (var dinner in currentPerson.Dinners)
            {
                mainTable.Rows.Add(dinner.Id, dinner.StartAt.ToString("HH:mm"), dinner.EndAt?.ToString("HH:mm"));
            }

        }

        private void RefreshValues() {
            double totalMinutes = currentPerson.Dinners.Sum(x =>
                {
                    return (x.EndAt.HasValue) ? x.EndAt.Value.Subtract(x.StartAt).TotalMinutes : 0;
                }
            );

            NumberCount.Text = Math.Round(totalMinutes).ToString();
        }
    }
}
