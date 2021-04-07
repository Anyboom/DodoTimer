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
            mainTable.Columns.Add("фамилия", typeof(string));
            mainTable.Columns.Add("Отчество", typeof(string));

            using(var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                foreach (Person item in db.GetCollection<Person>().Include(x => x.Dinners).FindAll())
                {
                    mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.MiddleName);
                }
            }

            MainGridView.DataSource = mainTable;

            ContextMenuStrip mainMenu = new ContextMenuStrip();

            ToolStripMenuItem showDinners = new ToolStripMenuItem("Показать обеды");

            showDinners.Click += delegate
            {
                int currentId = (int) MainGridView.SelectedRows[0].Cells[0].Value;

                using (var db = new LiteDatabase(Settings.NameOfDataBase))
                {
                    Person currentPerson = db.GetCollection<Person>().FindById(currentId);

                    currentPerson.Dinners = db.GetCollection<Dinner>().Find(x => x.PersonId == currentId).ToList();

                    DinnerForm tempForm = new DinnerForm(currentPerson);

                    tempForm.ShowDialog();
                }
            };

            mainMenu.Items.Add(showDinners);

            MainGridView.ContextMenuStrip = mainMenu;

            MainGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Dinner>();

                DateTime not = DateTime.Now;

                col.Insert(new Dinner()
                {
                    EndAt = DateTime.Now.AddMinutes(10),
                    StartAt = DateTime.Now,
                    PersonId = 1
                });
            }
        }
    }
}
