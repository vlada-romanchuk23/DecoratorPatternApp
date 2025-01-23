using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp
{
    public abstract class TableDecorator : ITable
    {
        protected ITable _table;

        protected TableDecorator(ITable table)
        {
            _table = table;
        }

        public virtual void Display()
        {
            _table.Display();
        }
    }

}
