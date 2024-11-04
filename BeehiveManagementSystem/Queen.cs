using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee
    {
        public override float CostPerShift { get { return 2.15f; } }

        private Bee[] workers;

        void AddWorker(Bee bee)
        {
            workers[] = bee;
        }

        void AssignBee(string jobName)
        {
            switch (jobName)
            {
                case "EggCare":
                    AddWorker(new EggCare(this));
                    break;
                case "HoneyManufacturer":
                    AddWorker(new HoneyManufacturer(this));
                    break;
                case "NectarCollector":
                    AddWorker(new NectarCollector(this));
                    break;
                    


            }
        }

        public Queen() : base("Queen")
        {
        }
        protected override void DoJob()
        {
            base.DoJob();
        }
    }
}
