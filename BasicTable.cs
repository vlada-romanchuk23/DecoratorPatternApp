using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    public class BasicTable : ITable
    {
        private readonly List<string[]> _data;

        public BasicTable(List<string[]> data)
        {
            _data = data;
        }

        public void Display()
        {
            // Вивід таблиці у консоль
            foreach (var row in _data)
            {
                Console.WriteLine(string.Join(" | ", row));
            }
        }

        public List<string[]> GetData()
        {
            return _data;
        }
    }


}
