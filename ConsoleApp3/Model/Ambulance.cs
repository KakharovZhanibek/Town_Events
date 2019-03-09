using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town.Model
{
    public class Ambulance : Receiver
    {
        public Ambulance(NewTown town) : base(town) { }

        public override void It_is_Fire(object sender, FireEventArgs e)
        {
            const string OK =
                "Скорая оказала помощь!";
            const string NOK =
                "Есть пострадавшие! Требуются лекарства.";
            if (rnd.Next(0, 10) > 2)
                e.Result = OK;
            else e.Result = NOK;
        }
    }
}
