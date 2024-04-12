namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Open Close Principle 
            /* Here we only use Abstract class to overcome modification in concrete class and make the class extensible  */
            List<Insurance> insurance = new List<Insurance>();
            insurance.Add(new HealthInsurance(1, "John"));
            insurance.Add(new MotorInsurance(2, "Jason"));
            //Un Comment to see the error
            //insurance.Add(new TermInsurance(3, "Mike"));
            foreach (var employee in insurance)
            {
                Console.WriteLine(string.Format("Customer {0} PremiumWithNCBDiscount: {1} Premium: {2}",
                employee.ToString(),
                employee.CalculateNCBDiscount(50).ToString(),
                employee.GetbasePremium().ToString()));
            }

            Console.WriteLine();

            // Liskov Substitution Principle
            /* Here we only use Open and close principle with interfaces for uncommon functionality
             * Here Term Insurance is not having No claim bonus hence we added interface for Insurancepremium and isolated No claim bonus function*/
            List<IInsurancePremium> employeesOnly = new List<IInsurancePremium>();

            employeesOnly.Add(new HealthInsurance(1, "John"));
            employeesOnly.Add(new MotorInsurance(2, "Jason"));
            employeesOnly.Add(new TermInsurance(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Customer {0}  Premium: {1}",
                employee.ToString(),
                employee.GetbasePremium().ToString()));
            }
            Console.ReadLine();
        }
    }
}