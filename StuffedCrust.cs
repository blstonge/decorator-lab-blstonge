namespace decorater_lab_blstonge
{
    public class StuffedCrust : Pizza
    {
        public StuffedCrust()
        {
            Description = "Stuffed Crust Pizza";
        }

        public override double Cost()
        {
            double cost = 0;

            switch(Size)
            {
                case "Small":
                    cost += 10.00;
                    break;
                case "Medium":
                    cost += 12.00;
                    break;
                case "Large":
                    cost += 14.00;
                    break;
            }

            return cost;
        }
    }
}