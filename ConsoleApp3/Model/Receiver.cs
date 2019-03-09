using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town.Model
{
    public abstract class Receiver
    {
        protected NewTown town;
        protected Random rnd = new Random();

        public Receiver(NewTown town)
        {
            this.town = town;
        }

        public void On()
        {
            town.Fire += new FireEventHandler(It_is_Fire);
        }

        public void Off()
        {
            town.Fire -= new FireEventHandler(It_is_Fire);
        }

        public abstract void It_is_Fire(object sender, FireEventArgs e);
    }
}
