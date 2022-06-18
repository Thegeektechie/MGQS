
using System;

namespace AlphaApp
{
  class Program
  {
    static void Main(string[] args)
    {

Console.WriteLine("                            ----------------------Question 1--------------------");

Console.WriteLine("Write a program thats gets the value of two words from an input.	a. Get the length of each word 	b. Add the result of the two lengths gotten from (a)	c. Using the ternary operator, check if the resultant value from (b) is greater than 20 		i. If true multiply the result by 3. 		ii. Otherwise add 20 to the result.");
Console.WriteLine("  ");
Console.WriteLine("Solution");
Console.WriteLine("  ");
Console.WriteLine("Enter your First Input:");
string inputOne = Console.ReadLine();
int inputOneLength = inputOne.Length;

Console.WriteLine("Enter your Second Input:");

string inputTwo = Console.ReadLine();

int inputTwoLength = inputTwo.Length;

Console.WriteLine("Your First Input has " + inputOneLength + " letters, While your Second input has " + inputTwoLength + " letters");

int TotalLength = inputOneLength + inputTwoLength;

Console.WriteLine("The addition of your First and Second Input is " + TotalLength);

  int True	= TotalLength * 3;
  int False = TotalLength + 20;
  Console.WriteLine((TotalLength > 20) ? "The answer is true, so therefore the length of the 2 input multiply 3 is " + True: "The answer is False, so therefore the length of the 2 input + 20 is " + False );


Console.WriteLine("  ");
Console.WriteLine("  ");




Console.WriteLine("                            ----------------------Question 2--------------------");
 Console.WriteLine("Write a program to calculate the profit between the cost price of a product of $200.876 whose selling price is $255.425. The result should be in two decimal places.");
 Console.WriteLine ("Solution");
  Console.WriteLine("Profit = Selling Price - Cost Price.");
  float SellingPrice = 255.425F;
  float CostPrice = 200.876F;
  Console.WriteLine ("Profit = 255.425 - 200.876");
  float profit = (float)(SellingPrice - CostPrice);
  Console.WriteLine("Profit = $" + Math.Round(profit, 2));
  




Console.WriteLine("                            ----------------------Question 3--------------------");
Console.WriteLine("  Get the index of the third character of any given string. 	- Add the value of the index to the length of the whole string.	- Convert the result of the above to a character " );
Console.WriteLine("Solution");







Console.WriteLine("                            ----------------------Question 4--------------------");

  Console.WriteLine(" Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional or the tenary operator statements.");
  Console.WriteLine("Solution");
  Console.WriteLine("Enter your First Input:");

int FirstInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Input:");

int SecondInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(".... Recorded");
Console.WriteLine("Your First Input is " + FirstInput + ", Your second input is " + SecondInput);
Console.WriteLine("The larger input is " + Math.Max(FirstInput, SecondInput) );





Console.WriteLine("  ");
Console.WriteLine("  ");



Console.WriteLine("                            ----------------------Question 5--------------------");
Console.WriteLine(" Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number. (Hint: use a while loop to solve the problem here. Also read about the Parse(), TryParse() method) ");
Console.WriteLine("Solution");
            

            
            int num = 5;
            int sum = 0;
            bool parseTry = false; 

            Console.WriteLine("Input any five whole numbers of your choice: ");
            
                int num_count = 0;
                for (int i = 1; i <= num; i++)
                {
                    parseTry = false;
                    do {
                           string str = Console.ReadLine();
                           
                           parseTry = Int32.TryParse(str, out int parsed);

                          if (parseTry == true)
                           {
                               sum += parsed; num_count++;
                           }
                           else
                           {
                               Console.WriteLine("Invalid Input!!!, Enter a whole number.");
                           }

                    }while(parseTry == false);

                }

                if (num_count >= 3)
                {

                    Console.WriteLine("Your sum is: " + sum);
                }






    Console.WriteLine("  ");

            Console.WriteLine("                            ----------------------Question 6--------------------");
        Console.WriteLine("  ");
  Console.WriteLine(" The sum of two numbers collected from user input, substracted from a constant value of 5.(Sample expression: number1 + number2 - 5). ");
    Console.WriteLine("  ");
  Console.WriteLine("Solution");

Console.WriteLine("Enter your First Input:");  
int Input1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Input:");

int Input2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(".... Recorded");
Console.WriteLine("Your First Input is " + Input1 + ", Your second input is " + Input2);
Console.Write(Input1 + " + " + Input2 + " -  5 = ");
int result = Input1 + Input2 - 5;

Console.Write(result);
Console.WriteLine("  ");
Console.WriteLine("  ");
            Console.WriteLine("                            ----------------------Question 7--------------------");
  Console.WriteLine("  ");
            Console.WriteLine("  Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.");
       Console.WriteLine("  ");
    Console.WriteLine("Please enter a number between 0 and 9:");
        string a = Console.ReadLine();
 
        switch (a)
        {
            case "0": Console.WriteLine("zero"); break;
            case "1": Console.WriteLine("one"); break;
            case "2": Console.WriteLine("two"); break;
            case "3": Console.WriteLine("three"); break;
            case "4": Console.WriteLine("four"); break;
            case "5": Console.WriteLine("five"); break;
            case "6": Console.WriteLine("six"); break;
            case "7": Console.WriteLine("seven"); break;
            case "8": Console.WriteLine("eight"); break;
            case "9": Console.WriteLine("nine"); break;
            default: Console.WriteLine("not a digit"); break;
        }
    }
  }
}


