using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town.Model
{
    public class Police : Receiver
    {
        public Police(NewTown town) : base(town) { }

        public override void It_is_Fire(object sender, FireEventArgs e)
        {
            const string OK =
                "Милиция нашла виновных!";
            const string NOK =
                "Милиция не нашла виновных! Следствие продолжается.";
            if (rnd.Next(0, 10) > 6)
                e.Result = OK;
            else e.Result = NOK;
        }
    }
}
