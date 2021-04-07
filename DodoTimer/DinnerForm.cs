using DodoTimer.Models;
using DodoTimer.Services;

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
    public partial class DinnerForm : Form
    {
        private Person currentPerson;
        private DataTable mainTable;

        internal DinnerForm(Person person)
        {
            InitializeComponent();

            currentPerson = person;

            mainTable = new DataTable();

            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Начало", typeof(TimeSpan));
            mainTable.Columns.Add("Конец", typeof(TimeSpan));

            foreach (var dinner in currentPerson.Dinners)
            {
                mainTable.Rows.Add(dinner.Id, dinner.StartAt.ToString("HH:mm:ss"), dinner.EndAt.ToString("HH:mm:ss"));
            }

            MainGroupBox.Text = $"{currentPerson.FirstName} {currentPerson.LastName}";

            NumberCountLabel.Text = currentPerson.Dinners.Sum(x => (x.EndAt - x.StartAt).TotalMinutes).ToString();

            MainGrid.DataSource = mainTable;
        }
    }
}
