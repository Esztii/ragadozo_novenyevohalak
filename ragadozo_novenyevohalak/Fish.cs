namespace ragadozo_novenyevohalak
{
    internal class Fish
    {
        private float weight;
        private bool weightIsSet = false;
        private bool predator;
        private bool predatorIsSet = false;
        private int top;
        private int depth;
        private string species;

        public float Weight
        {
            get => weight;
            set
            {
                if (value < .5f || value > 40f)
                    throw new Exception("a hal súlya nem megfelelő");

                if (weightIsSet && ( value > weight * 1.1 || value < weight * 0.9))
                    throw new Exception("a hal súlya ennyivel nem változhat");
                weight = value;
                weightIsSet = true;
            }
        }
        public bool Predator { get; private set; }

        public int Top 
        { 
            get => top;
            set
            {
                if (value < 0 || value > 400)
                    throw new Exception("invalid érték");
                top = value;
            }
        }
        public int Depth
        {
            get => depth;
            set
            {
                if (value < 10 || value > 400)
                    throw new Exception("invalid érték");
                depth = value;
            }
        }
        public string Species
        {
            get => species;
            set
            {
                if (value is null)
                    throw new Exception("nem lehet null");
                if (value.Length < 3 || value.Length > 30)
                    throw new Exception("Nem megfelelő hossz.");
                species = value;
            }
        }

        public Fish(float weight, bool predator, int top, int depth, string species)
        {
            Weight = weight;
            Predator = predator;
            Top = top;
            Depth = depth;
            Species = species;
        }
    }
}
