using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town.Model
{
    public class FireDetect : Receiver
    {
        public FireDetect(NewTown town) : base(town) { }

        public override void It_is_Fire(object sender, FireEventArgs e)
        {
            const string OK =
                 "Пожарные потушили пожар!";
            const string NOK =
                 "Пожар продолжается! Требуется помощь.";
            if (rnd.Next(0, 10) > 4)
                e.Result = OK;
            else e.Result = NOK;
        }
    }
}
