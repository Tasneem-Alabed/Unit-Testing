using System;

namespace Unit_Testing
{
    public static class Program
    {
        static public decimal Balance =10;
        static void Main(string[] args)
        {   //welcoming masseg
            Console.WriteLine("Hello!");

           
            try
            {
                int number;
                do
                {   //help to chese the prosess
                    Console.WriteLine("Plaec Enter 1 to view your balance");
                    Console.WriteLine("Plaec Enter 2 to take from your balance");
                    Console.WriteLine("Plaec Enter 3 to add to your balance");
                    Console.WriteLine("Plaec Enter 0 to exit");
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            {
                             ViewBalance();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Please Enter how mach you want ");
                                decimal ordermony= Convert.ToDecimal(Console.ReadLine());
                                //check about the order number
                                if (ordermony > 0 && ordermony < Balance)
                                {
                                    Withdraw(ordermony);
                                }
                                else if (ordermony <= 0 )
                                {
                                    Console.WriteLine("you should enter number greater than 0");
                                }
                                else if (ordermony > Balance)
                                {
                                    Console.WriteLine($"you did not have enough in your Balance , your Balance = {Balance} ");
                                }
                            }
                            break;
                        case 3:
                            {   
                                //check about the add amount
                                Console.WriteLine("Please Enter how mach you want ");
                                decimal addNumber = Convert.ToDecimal(Console.ReadLine());
                                if (addNumber > 0)
                                {
                                    Deposit(addNumber);
                                }
                                else
                                {
                                    Console.WriteLine("You should Enter number greater than 0");
                                }

                            }
                            break;
                        
                        default: {
                                Console.WriteLine("Wrong Input");
                            }
                            break;
                    }
                }while (number!=0);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("The app is completed"); }

        }
        //method to show the balance
       public static void ViewBalance()
        {
            Console.WriteLine($"Your balanse = {Balance}");
        }
        //method to subtrace from balance
        public static decimal Withdraw(decimal a)
        {
            Balance = Balance - a;
            Console.WriteLine($"Your balance = {Balance}");
            return Balance;
        }
        //method to add to the balance
        public static decimal Deposit(decimal x)
        {
            Balance = Balance + x;
            Console.WriteLine($"Your balance = {Balance}");
            return Balance;
        }


    }
}