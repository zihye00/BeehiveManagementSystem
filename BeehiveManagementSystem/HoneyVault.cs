namespace BeehiveManagementSystem
{
    static class HoneyVault
    {

        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;

        public static void CollectNectar(float amount)
        {
            if (amount > 0)
            {
                nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            var convertNectar = amount;
            if (convertNectar > nectar)
            {
                convertNectar = nectar;
            }

            nectar -= convertNectar;
            honey += convertNectar * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;

                return true;
            }
            else
            {
                return false;
            }
        }
        public static string StatusReport
        {
            get
            {
                string warning = "";
                if (honey < LOW_LEVEL_WARNING) { warning = "LOW HONEY - ADD A HONEY MANUFACTURER"; }
                return warning;
            }
        }
    }
}
