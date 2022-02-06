// // See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
namespace basiclearning
{
    class Program
    {
        static void Main(string[] args)
        {
           int amount=1000, deposit, withdraw;
           int choice;
           Console.WriteLine("Enter your PIN NUMBER : ");
           int pin = Convert.ToInt32(Console.ReadLine());
           List<Details> l1=new List<Details>();
           l1.Add(new Details(){
               Code=1010,
               Name="Riya"
           });
           
           if(pin==l1[0].Code)
           {
               Console.WriteLine(l1[0].Name + " Welcome");
            while(true)
            {
                Console.WriteLine("****Welcome to ATM System****\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("Enter your choice : ");
                int.TryParse(Console.ReadLine(),out choice);
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ",amount);
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("\n ENTER THE AMOUNT TO BE WITHDRAWN : ");
                        int.TryParse(Console.ReadLine(),out withdraw);
                        if(withdraw%100 != 0)
                        {
                            Console.WriteLine("\n PLEASE WRITE THE VALUE IN THE MULTIPLES OF 100");
                        }
                        else if(withdraw>(amount-500))
                        {
                            Console.WriteLine("INSUFFICIENT BALANCE");
                        }
                        else
                        {
                            amount-=withdraw;
                            Console.WriteLine("\n Please Colect the Cash");
                            Console.WriteLine("Your Current Balance is  : {0}",amount);
                        }
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("\n ENTR THE AMOUNT TO BE DEPOSITED");
                        int.TryParse(Console.ReadLine(),out deposit);
                        amount=amount+deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}",amount);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("\n Thank you using ATM \n");
                        Console.WriteLine("\n Please Collect the slip \n");
                        break;
                    }
                }
                Console.WriteLine("\n\n THANKS FOR USING ATM SERVICE");
            }
           } 
           else
           {
               Console.WriteLine("\nWrong PIN Entered, check and fill correctly.....!!!");
           }
        }
    }
}

