using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    interface IInsurancePremium
    {
        int ID { get; set; }
        string CustName { get; set; }
        decimal GetbasePremium();
    }
    interface INoclaimBonus
    {
        decimal CalculateNCBDiscount(decimal basepremium);
    }
    public abstract class Insurance : IInsurancePremium, INoclaimBonus
    {
        public int ID { get; set; }

        public string CustName { get; set; }

        public Insurance()
        { }

        public Insurance(int id, string custname)
        {
            this.ID = id;
            this.CustName = custname;

        }

        public abstract decimal CalculateNCBDiscount(decimal basepremium);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.CustName);
        }

        public abstract decimal GetbasePremium();
    }
    public class HealthInsurance : Insurance
    {
        public HealthInsurance()
        { }

        public HealthInsurance(int id, string Custname) : base(id, Custname)
        { }

        public override decimal CalculateNCBDiscount(decimal Percent)
        {
            return (GetbasePremium() - (GetbasePremium() * Percent/ 100));
        }

        public override decimal GetbasePremium()
        {
            return 15000;
        }
    }
    public class MotorInsurance : Insurance
    {
        public MotorInsurance()
        { }

        public MotorInsurance(int id, string Custname) : base(id, Custname)
        { }

        public override decimal CalculateNCBDiscount(decimal Percent)
        {
            return (GetbasePremium() - (GetbasePremium() * Percent / 100));
        }

        public override decimal GetbasePremium()
        {
            return 5000;
        }
    }
    public class TermInsurance : IInsurancePremium
    {
        public int ID { get; set; }

        public string CustName { get; set; }
        public TermInsurance()
        { }

        public TermInsurance(int id, string custname)
        {
            this.ID = id;
            this.CustName = custname;
        }

        public decimal GetbasePremium()
        {
            return 7000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.CustName);
        }
    }
}
