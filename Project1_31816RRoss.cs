using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday_Big_Project
{
    class Program
    {
        static void Main(string[] args)
        {   //INITIALIZE SOME VARIABLES AT THIS SCOPE FOR USE LATER
            string playAnswer = "Y";//setting this up to ask again at the end
            string retireMoney = "$0";
            int retireAge = 0;
            string vacationHome = "home";
            string vehicle = "sailboat";
            //GET USER INPUT
            while (playAnswer == "Y" || playAnswer == "YES")//this will play at least once
            {
                Console.WriteLine("What is your First Name?");//get user first name
                string firstName = Console.ReadLine();
                Console.WriteLine("What is your Last Name?");//get last name
                string lastName = Console.ReadLine();
                Console.WriteLine("What is your birth month?");//get birth month
                string month = Console.ReadLine();
                Console.WriteLine("What is your age?");//get age
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("How many siblings do you have?");//get siblings #
                int siblings = int.Parse(Console.ReadLine());
                //USER COLOR SECTION
                string colorAns = "HELP"; //initial value is help so it will run at least once
                while (colorAns == "HELP")
                {
                    Console.WriteLine("Give me your favorite color, ROYGBIV - for help type \"help\"");
                    string colors = Console.ReadLine();
                    colorAns = colors.ToUpper();//change to upper case for ease of use
                    if (colorAns == "HELP")//if they write help, give help and loop back to ask again 
                    {
                        Console.WriteLine("ROYGBIV = Red, Orange, Yellow, Green, Blue, Indigo, Violet");//the help
                    }
                }
                    
                switch (colorAns)//fall out of the help loop down to here when they answer something other than help
                {
                    case "RED"://red and r can both be the same case (etc. for other colors) 
                    case "R":
                        vehicle = "Lamborghini";
                        break;
                    case "ORANGE":
                    case "O":
                        vehicle = "camel";
                        break;
                    case "YELLOW":
                    case "Y":
                        vehicle = "pickup truck";
                        break;
                    case "GREEN":
                    case "G":
                        vehicle = "plane";
                        break;
                    case "BLUE":
                    case "B":
                        vehicle = "skateboard";
                        break;
                    case "INDIGO":
                    case "I":
                        vehicle = "moped";
                        break;
                    default:
                        vehicle = "hovercraft";
                        break;
                }//USER SIBLINGS SECTION
                switch (siblings)
                {
                    case 0: //if siblings = 0, then you will live in Atlanta
                        vacationHome = "Atlanta";
                        break;
                    case 1: //if one siblings = Boston
                        vacationHome = "Boston";
                        break;
                    case 2: //if 2 siblings = Charlotte
                        vacationHome = "Charlotte";
                        break;
                    case 3: //if 3 siblings =  Denver
                        vacationHome = "Denver";
                        break;
                    default: //if more than 3 =  England
                        vacationHome = "England";
                        break;
                }
                //USER AGE SECTION
                //if user age is odd, retire in 5 years, if even retire in 10 years
                if (age % 2 == 0)//this means it is even
                {
                    retireAge = 10;
                }
                else //other than even = odd
                {
                    retireAge = 5;
                }
                //IS BIRTH MONTH FOUND IN NAME? COMPARE FIRST AND LAST 
                string upperMonth = month.ToUpper();//convert month to uppercase in case they put it in lowercase
                string upperFirst = firstName.ToUpper();//convert first name to uppercase
                string upperLast = lastName.ToUpper();//convert last name to uppercase
                if (upperMonth[0] == upperFirst[0] || upperMonth[0] == upperLast[0])
                {//compare first letter of first name & first letter of last name to first letter of birth month
                    retireMoney = "$100";
                }
                else if (upperMonth[0] == upperFirst[1] || upperMonth[0] == upperLast[1])
                {
                    retireMoney = "$4562.18";
                }
                else if (upperMonth[0] == upperFirst[2] || upperMonth[0] == upperLast[2])
                {
                    retireMoney = "7 MILLION DOLLARS";
                }
                else //didn't match first 3 letters of first or last name, default to this:
                {
                    retireMoney = "$TEN MILLION DOLLARS$";
                }
                //FINAL OUTPUT:
                //[First Name] [Last Name] will retire in [#] years, 
                //with [Amount of Money] in the bank, a vacation home in [Location] and a [vehicle]
                Console.WriteLine("\n I will now predict your future! \n...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(firstName + " " + lastName + " will retire in " + retireAge + " years, with  " + retireMoney + " in the bank, a vacation home in " + vacationHome + " and a " + vehicle + ".\n");
                //ask if you want to play again:
                Console.WriteLine("Do you want to play again? Y/N");
                string playAgain = Console.ReadLine();
                playAnswer = playAgain.ToUpper();
                if (playAnswer == "N" || playAnswer == "NO" )
                {
                    Console.WriteLine("Thanks for playing! This fortune is intended for entertainment purposes only.");
                }
            }
        }
        //I guess I will work on the bonus stuff later. 
    }
}
