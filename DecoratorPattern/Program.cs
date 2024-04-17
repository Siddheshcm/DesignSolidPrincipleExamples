using DecoratorPattern.Decorator;
using DecoratorPattern.Objects;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Decorator Pattern is used to tackle Class Explosion when you dont know which decorators of features will be used 
             * and hence we cannot create all the combinations for E.g.  in Pizza there can be extra cheese or extra olives depend 
             * on selection. 
             * Here we use Abstract class with both IS A and Has A Relationship.
             
             */


            BasePizza objpizza = new ExtraCheese(new MargeritaPizza());

            Console.WriteLine("Pizza Cost : " + objpizza.cost());
            
        }
    }
}