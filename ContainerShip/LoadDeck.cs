using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    class LoadDeck
    {
        public int Rows { get; set; }

        public int Columns { get; set; }

        public LoadDeck(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            InitializeShipRows();
            InitializeShipStacks();
        }


        public List<Row> InitializeShipRows()
        {
            List<Row> _RowsOnLoadDeck = new List<Row>();

            for (int i = 0; i < Rows; i++)
            {
                Row row = new Row();
                _RowsOnLoadDeck.Add(row);
            }
            return _RowsOnLoadDeck;
        }


        public List<Stack> InitializeShipStacks() // Elke stack, is een kolomplaats waar een lijst van containers op kan staan
        {
            List<Stack> _stacks = new List<Stack>();

            for (int i = 0; i < Columns; i++)
            {
                Stack stack = new Stack();
                _stacks.Add(stack);
            }

        return _stacks;
        }


    }
}
