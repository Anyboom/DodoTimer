using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DodoTimer.Models;
using DodoTimer.Services;

using LiteDB;

namespace DodoTimer
{
    public partial class MainForm : Form
    {
        private DataTable mainTable;

        public MainForm()
        {
            InitializeComponent();

            mainTable = new DataTable();

            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Имя", typeof(string));
            mainTable.Columns.Add("Фамилия", typeof(string));
            mainTable.Columns.Add("Открыт", typeof(bool));

            MainGrid.CellFormatting += (sender, args) =>
            {
                if ((bool) MainGrid[3, args.RowIndex].Value) 
                {
                    MainGrid.Rows[args.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0xd3, 0xd3, 0xd3);
                }
            };

            mainTable.PrimaryKey = new[]{ mainTable.Columns[0] };

            ContextMenuStrip mainMenu = new ContextMenuStrip();

            ToolStripMenuItem showDinners = new ToolStripMenuItem("Показать обеды");
            
            ToolStripMenuItem actionPerson = new ToolStripMenuItem("Персонал");
            ToolStripMenuItem addPerson = new ToolStripMenuItem("Добавить");
            ToolStripMenuItem removePerson = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem editPerson = new ToolStripMenuItem("Редактировать");

            ToolStripMenuItem refreshTable = new ToolStripMenuItem("Обновить таблицу");

            actionPerson.DropDownItems.Add(addPerson);
            actionPerson.DropDownItems.Add(removePerson);
            actionPerson.DropDownItems.Add(editPerson);

            showDinners.Click += (sendor, e) => ShowDinners();

            addPerson.Click += (sendor, e) => AddPerson();

            removePerson.Click += (sendor, e) => RemovePerson();

            editPerson.Click += (sendor, e) => EditPerson();

            refreshTable.Click += (sendor, e) => RefreshPersons();

            this.Shown += (sender, e) =>
            {
                MainGrid.Columns[0].Visible = false;
                MainGrid.Columns[3].Visible = false;

                MainGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                MainGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            };

            mainMenu.Items.Add(showDinners);
            mainMenu.Items.Add(new ToolStripSeparator());
            mainMenu.Items.Add(actionPerson);
            mainMenu.Items.Add(new ToolStripSeparator());
            mainMenu.Items.Add(refreshTable);

            MainGrid.DataSource = mainTable;

            MainGrid.ContextMenuStrip = mainMenu;

            RefreshPersons();
        }

        private void RemovePerson()
        {
            if (MainGrid.SelectedRows.Count == 0)
            {
                MessageService.ShowInfo("Нужно выбрать сотрудника для удаления.");

                return;
            }

            int currentId = (int)MainGrid.SelectedRows[0].Cells[0].Value;

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Person>();

                Person personForRemove = col.FindById(currentId);

                DialogResult result = MessageService.ShowQuestion($"Вы точно хотите удалить сотрудина #{personForRemove.Id} {personForRemove.FirstName} {personForRemove.LastName} ?", MessageBoxButtons.YesNo);
            
                if(result == DialogResult.Yes)
                {
                    personForRemove.Deleted = true;

                    col.Update(personForRemove);

                    LogService.Info($"Модель была удалена: #{personForRemove.Id} {personForRemove.FirstName} {personForRemove.LastName}");

                    mainTable.Rows.Find(personForRemove.Id).Delete();
                }
            }
        }

        private void EditPerson()
        {
            if (MainGrid.SelectedRows.Count == 0)
            {
                MessageService.ShowInfo("Нужно выбрать сотрудника для редактирования.");

                return;
            }

            int currentId = (int)MainGrid.SelectedRows[0].Cells[0].Value;

            ActionForm tempForm = new ActionForm(currentId);

            DialogResult result = tempForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Person returnedPerson = tempForm.MainPerson;

                LogService.Info($"Модель была изменена: #{returnedPerson.Id} {returnedPerson.FirstName} {returnedPerson.LastName}");

                mainTable.Rows.Find(currentId).SetField(1, returnedPerson.FirstName);
                mainTable.Rows.Find(currentId).SetField(2, returnedPerson.LastName);
            }
        }

        private void AddPerson()
        {
            ActionForm tempForm = new ActionForm();

            DialogResult result = tempForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                Person returnedPerson = tempForm.MainPerson;

                LogService.Info($"Модель была добавлена: #{returnedPerson.Id} {returnedPerson.FirstName} {returnedPerson.LastName}");

                mainTable.Rows.Add(returnedPerson.Id, returnedPerson.FirstName, returnedPerson.LastName, false);
            }
        }

        private void RefreshPersons()
        {
            int? currentSelectedId = null;

            if (MainGrid.SelectedRows.Count > 0){
                currentSelectedId = (int) MainGrid.SelectedRows[0].Index;
            }

            mainTable.Clear();

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                List<Dinner> dinners = db.GetCollection<Dinner>().FindAll().ToList();

                foreach (Person item in db.GetCollection<Person>().Find(x => x.Deleted == false))
                {
                    bool existsPerson = dinners.Any(x => x.PersonId == item.Id && x.StartAt.Day == DateTime.Now.Day && x.EndAt == null);

                    mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, existsPerson);
                }
            }

            MainGrid.Sort(MainGrid.Columns[3], ListSortDirection.Descending);

            if (currentSelectedId != null)
            {
                MainGrid.Rows[currentSelectedId.Value].Selected = true;
            }
        }

        private void ShowDinners()
        {
            if (MainGrid.SelectedRows.Count == 0)
            {
                MessageService.ShowInfo("Нужно выбрать сотрудника.");

                return;
            }

            int currentId = (int)MainGrid.SelectedRows[0].Cells[0].Value;

            DinnerForm tempForm = new DinnerForm(currentId);

            tempForm.ShowDialog();

            RefreshPersons();
        }
    }
}
