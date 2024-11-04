namespace BeehiveManagementSystem
{
    public class HoneyManufacturer : Bee
    {
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer() : base("HoneyManufacturer")
        {

        }

        protected override void DoJob()
        {
            base.DoJob();
        }

    }
}

