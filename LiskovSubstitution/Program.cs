namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
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