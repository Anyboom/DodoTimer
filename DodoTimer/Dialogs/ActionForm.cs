using DodoTimer.Models;
using DodoTimer.Services;

using LiteDB;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodoTimer
{
    public partial class ActionForm : Form
    {
        internal Person MainPerson { get; private set; }

        public ActionForm()
        {
            InitializeComponent();

            this.Load += (_sender, _e) => FormLoad();
        }

        private void FormLoad()
        {
            if (MainPerson == null)
            {
                ActionButton.Click += (sender, e) => AddPerson();
            }
            else
            {
                ActionButton.Click += (sender, e) => EditPerson();

                FirstNameTextBox.Text = MainPerson.FirstName;
                LastNameTextBox.Text = MainPerson.LastName;

                this.Text = "Редактирование сотрудника";
                ActionButton.Text = "Изменить";
            }
        }

        internal ActionForm(int id) : this()
        {
            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Person>();

                MainPerson = col.FindById(id);
            }
        }

        private void AddPerson()
        {
            ValidateForm();

            MainPerson = new Person();

            MainPerson.FirstName = FirstNameTextBox.Text;
            MainPerson.LastName = LastNameTextBox.Text;

            using(var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Person>();

                BsonValue addedPerson = col.Insert(MainPerson);

                MainPerson.Id = addedPerson.AsInt32;
            }

            DialogResult = DialogResult.OK;

            Close();
        }

        private void EditPerson()
        {
            ValidateForm();

            MainPerson.FirstName = FirstNameTextBox.Text;
            MainPerson.LastName = LastNameTextBox.Text;

            using (var db = new LiteDatabase(Settings.NameOfDataBase))
            {
                var col = db.GetCollection<Person>();

                col.Update(MainPerson);
            }

            DialogResult = DialogResult.OK;

            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageService.ShowError("Поле 'Имя' не заполнено.");

                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageService.ShowError("Поле 'Фамилия' не заполнено.");

                return false;
            }

            return true;
        }
    }
}
