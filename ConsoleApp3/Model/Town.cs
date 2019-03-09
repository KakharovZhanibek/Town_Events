using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Town.Model;

namespace Town
{
    public delegate void FireEventHandler(object sender, FireEventArgs e);

    public class NewTown
    {
        public string townName { get; set; }
        public int buildings { get; set; }
        public int days { get; set; }

        Police policeman;
        Ambulance ambulanceman;
        FireDetect fireman;

        public event FireEventHandler Fire;
        string[] resultService;

        private Random rnd = new Random();

        double fireProbability;

        public NewTown(string name, int buildings, int days)
        {
            townName = name;
            this.buildings = buildings;
            this.days = days;
            fireProbability = 1e-3;

            policeman = new Police(this);
            ambulanceman = new Ambulance(this);
            fireman = new FireDetect(this);

            policeman.On();
            ambulanceman.On();
            fireman.On();
        }


        protected virtual void OnFire(FireEventArgs e)
        {
            const string MESSAGE_FIRE =
                        "В городе {0} пожар! Дом {1}. День {2}-й";
            Console.WriteLine(string.Format(MESSAGE_FIRE, townName,
                e.Building, e.Day));
            if (Fire != null)
            {
                Delegate[] eventHandlers =
                    Fire.GetInvocationList();
                resultService = new string[eventHandlers.Length];
                int k = 0;
                foreach (FireEventHandler evHandler in
                    eventHandlers)
                {
                    evHandler(this, e);
                    resultService[k++] = e.Result;
                }
            }
        }


        public void LifeOurTown()
        {
            const string OK =
               "В городе {0} все спокойно! Пожаров не было.";

            bool wasFire = false;

            for (int day = 1; day <= days; day++)
                for (int building = 1; building <= buildings; building++)
                {
                    if (rnd.NextDouble() < fireProbability)
                    {
                        FireEventArgs e = new FireEventArgs(building, day);
                        OnFire(e);
                        wasFire = true;
                        for (int i = 0; i < resultService.Length; i++)
                            Console.WriteLine(resultService[i]);
                    }
                }
            if (!wasFire)
                Console.WriteLine(string.Format(OK, townName));
        }
    }
}
