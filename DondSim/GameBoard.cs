using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DondSim
{
    class GameBoard
    {
        public List<double> _board { get; } = new List<double>()
        {
            0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750,
            1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000,
            750000, 1000000
        };

        public double getAverage()
        {
            return _board.Average();
        }

        public void removeValue(double valueToRemove)
        {
            if (_board.Contains(valueToRemove))
            {
                _board.Remove(valueToRemove);
            }
            else throw new ArgumentException("value to be removed was not found");
        }
    }
}
