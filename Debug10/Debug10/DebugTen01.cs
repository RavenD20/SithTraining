// Defines a base class named Customer
// And a child class FrequentCustomer who receives a discount
// Main program demonstrates a customer of each type
using static System.Console;
class DebugTen01
{
  public static void TenOne()
    {
        Customer aRegularCustomer = new Customer();
        FrequentCustomer aFrequentCustomer = new FrequentCustomer();
        aRegularCustomer.CustNum = 2514;
        aRegularCustomer.CustBalance = 765.00;
        aFrequentCustomer.CustNum = 5719;
        aFrequentCustomer.CustBalance = 2500.00;
        aFrequentCustomer.DiscountRate = 0.15;
        WriteLine("\naRegularCustomer #{0} owes {1}",
           aRegularCustomer.CustNum,
           aRegularCustomer.CustBalance.ToString("C2"));
        WriteLine("\naFrequentCustomer #{0} would owe {1} without the discount",
           aFrequentCustomer.CustNum,
           aFrequentCustomer.CustBalance.ToString("C2"));
        double newBal = (1 - aFrequentCustomer.DiscountRate) *
           aFrequentCustomer.CustBalance;
        WriteLine("...with {0} discount, customer owes {1}",
           aFrequentCustomer.DiscountRate.ToString("P"), newBal.ToString("C"));
        System.Console.ReadLine();
    }
   public class Customer
    {
        private int custNum;
        private double custBalance;
       public int CustNum
        {
            get
            {
                return custNum;
            }
            set
            {
                custNum = value;
            }
        }
        public double CustBalance
        {
            get
            {
                return custBalance;
            }
            set
            {
                custBalance = value;
            }
        }
    }
    class FrequentCustomer : Customer
    {
        private double discountRate;
        public double DiscountRate
        {
            get
            {
                return discountRate;
            }
            set
            {
                discountRate = value;
            }
        }
    }
}
