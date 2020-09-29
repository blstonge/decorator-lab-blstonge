namespace decorater_lab_blstonge
{
    public class DeepDish : Pizza
    {
        public DeepDish()
        {
            Description = "Deep Dish Pizza";
        }

        public override double Cost()
        {
            double cost = 0;

            switch(Size)
            {
                case "Small":
                    cost += 7.00;
                    break;
                case "Medium":
                    cost += 10.00;
                    break;
                case "Large":
                    cost += 12.00;
                    break;
            }

            return cost;
        }
    }
}