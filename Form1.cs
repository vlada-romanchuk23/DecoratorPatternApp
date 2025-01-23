using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPatternApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            // Дані для таблиці
            var data = new List<string[]>
    {
        new string[] { "ID", "Назва", "Рейтинг" },
        new string[] { "1", "Університет 1", "95" },
        new string[] { "2", "Університет 2", "90" }
    };

            // Створення базової таблиці
            ITable basicTable = new BasicTable(data);

            // Створення декоратора для відображення у DataGridView
            ITable visualTable = new VisualTableDecorator(basicTable, dataGridView1);

            // Виклик методу Display (вивід у консоль + у DataGridView)
            visualTable.Display();
        }


    }
}
