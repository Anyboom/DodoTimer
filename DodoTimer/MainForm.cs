using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            mainTable.Columns.Add("Отчество", typeof(string));

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

            removePerson.Click += (sendor, e) => { };

            editPerson.Click += (sendor, e) => { };

            refreshTable.Click += (sendor, e) => RefreshPersons();

            mainMenu.Items.Add(showDinners);
            mainMenu.Items.Add(new ToolStripSeparator());
            mainMenu.Items.Add(actionPerson);
            mainMenu.Items.Add(new ToolStripSeparator());
            mainMenu.Items.Add(refreshTable);

            MainGrid.DataSource = mainTable;

            MainGrid.Columns[0].Visible = false;

            MainGrid.ContextMenuStrip = mainMenu;

            RefreshPersons();

        }

        private void AddPerson()
        {
            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Person>();

                col.Insert(new Person()
                {
                    FirstName = "Ангелина",
                    LastName = "Компиянова",
                    MiddleName = "Сергеевна",
                    Deleted = false
                });
            }
        }

        private void RefreshPersons()
        {
            mainTable.Clear();

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                foreach (Person item in db.GetCollection<Person>().Find(x => x.Deleted == false))
                {
                    mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.MiddleName);
                }
            }
        }

        private void ShowDinners()
        {
            if (MainGrid.SelectedRows.Count == 0)
            {
                return;
            }

            int currentId = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            DinnerForm tempForm = new DinnerForm(currentId);

            tempForm.ShowDialog();
        }
    }
}
