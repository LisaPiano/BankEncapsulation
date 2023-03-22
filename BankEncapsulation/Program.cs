namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
        
            double depositAmount;
            bool isANumber;
            do
            {
                Console.WriteLine("Hello! Deposit Amount: ");
                isANumber = double.TryParse(Console.ReadLine(), out depositAmount);
            }
            while (isANumber == false);

            Console.WriteLine($"You have deposited: ${depositAmount.ToString("F2")}");

            myAccount.Deposit(depositAmount);

            double updatedAmount = myAccount.GetBalance();
            Console.WriteLine($"Thank you! Your current account balance is: ${updatedAmount.ToString("F2")}");


        }//end Main
    }//end Program
}//end namespace
