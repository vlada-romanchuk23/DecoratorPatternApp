using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPatternApp
{


    public class VisualTableDecorator : TableDecorator
    {
        private readonly DataGridView _dataGridView;

        public VisualTableDecorator(ITable table, DataGridView dataGridView)
            : base(table)
        {
            _dataGridView = dataGridView;
        }

        public override void Display()
        {
            // Виклик базового методу (вивід у консоль)
            base.Display();

            if (_table is BasicTable basicTable)
            {
                var data = basicTable.GetData();

                // Очищення DataGridView
                _dataGridView.Rows.Clear();
                _dataGridView.Columns.Clear();

                // Додати колонки
                for (int i = 0; i < data[0].Length; i++)
                {
                    _dataGridView.Columns.Add($"Column{i}", $"Колонка {i + 1}");
                }

                // Додати рядки
                foreach (var row in data)
                {
                    _dataGridView.Rows.Add(row);
                }
            }
        }
    }


}
