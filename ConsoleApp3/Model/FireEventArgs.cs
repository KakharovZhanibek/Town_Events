using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town.Model
{
    public class FireEventArgs : EventArgs
    {
        int building;
        int day;
        string result;

        public int Building { get { return building; } }
        public int Day { get { return day; } }

        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public FireEventArgs(int building, int day)
        {
            this.building = building; this.day = day;
        }
    }
}
