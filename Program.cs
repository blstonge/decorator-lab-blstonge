using System;

namespace decorater_lab_blstonge
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new DeepDish(){Size = "Large"};
            
            myPizza = new Cheese(myPizza);
            myPizza = new Cheese(myPizza);

            Console.WriteLine(myPizza.GetDescription() + " $" + myPizza.Cost());

            Pizza secondPizza = new Original(){Size = "Small"};

            secondPizza = new Cheese(secondPizza);
            secondPizza = new Pepperoni(secondPizza);
            secondPizza = new Sausage(secondPizza);

            Console.WriteLine(secondPizza.GetDescription() + " $" + secondPizza.Cost());
            
        }
    }
}
