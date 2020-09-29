namespace decorater_lab_blstonge
{
    public class Pepperoni : PizzaDecorater
    {
        Pizza pizza;
        public Pepperoni(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string GetDescription()
        {
            return pizza.GetDescription() + " , add Pepperoni";
        }
        public override string GetSize()
        {
            return pizza.GetSize();
        }
    
        public override void SetSize(string size)
        {
            pizza.SetSize(size);
        }
        public override double Cost()
        {
            double cost = pizza.Cost();
            
            switch(pizza.GetSize())
            {
                case "Small":
                    cost += 1.00;
                    break;
                case "Medium":
                    cost += 1.25;
                    break;
                case "Large":
                    cost += 1.75;
                    break;
            }

            return cost;
        }
    }
}