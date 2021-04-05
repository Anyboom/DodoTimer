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

using LiteDB;

namespace DodoTimer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MainGridView.Columns.Add("Id", "Ид");
            MainGridView.Columns.Add("FirstName", "Имя");
            MainGridView.Columns.Add("LastName", "Фамилия");
            MainGridView.Columns.Add("MiddleName", "Отчество");
        }
    }
}
