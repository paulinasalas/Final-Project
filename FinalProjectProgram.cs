using System;

namespace FinalProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reminder app!");
            Console.WriteLine(" Please type what you would like to remember");
            Console.WriteLine("Example: Remind me to buy Christmas gift");

            string remind1 = Console.ReadLine();

            //Saves month as a value
            Console.WriteLine("Please enter the month you would like to be reminded on");
            Console.WriteLine("Jan/Feb/Mar/Apr/May/June/Jul/Aug/Sep/Oct/Nov/Dec");

            string month1 = Convert.ToString(Console.ReadLine());

            //saves day as a value
            Console.WriteLine("Please enter the day you would like to be reminded on");
            Console.WriteLine("1-31");

            int day1 = Convert.ToInt32(Console.ReadLine());

            //saves year as a value
            Console.WriteLine("Please enter the year you like to be reminded on");
            Console.WriteLine("2000-2030");

            int year1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Reminder 1 : " + remind1);
            Console.WriteLine("Month it will be held on : " + month1);
            Console.WriteLine("Day it will be held on : " + day1);
            Console.WriteLine("Year it will be held on : " + year1);



            //saves yes or no for user to use again
            Console.WriteLine("Would you like to be reminded of anything else?");
            Console.WriteLine("Y/N");
            char answer1 = Convert.ToChar(Console.ReadLine());
            if (answer1 == 'N')
            {
                Console.WriteLine("Your alarm has been set!");
            }
            else
            {
                Console.WriteLine(" Please type what you would like to remember");
                Console.WriteLine("Example: Remind me to buy Christmas gift");

                string remind2 = Console.ReadLine();


                //Saves month as a value
                Console.WriteLine("Please enter the month you would like to be reminded on");
                Console.WriteLine("Jan/Feb/Mar/Apr/May/June/Jul/Aug/Sep/Oct/Nov/Dec");

                string month2 = Convert.ToString(Console.ReadLine());

                //saves day as a value
                Console.WriteLine("Please enter the day you would like to be reminded on");
                Console.WriteLine("1-31");

                int day2 = Convert.ToInt32(Console.ReadLine());

                //saves year as a value
                Console.WriteLine("Please enter the year you like to be reminded on");
                Console.WriteLine("2000-2030");

                int year2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Reminder 2 : " + remind2);
                Console.WriteLine("Month it will be held on : " + month2);
                Console.WriteLine("Day it will be held on : " + day2);
                Console.WriteLine("Year it will be held on : " + year2);

                Console.WriteLine("Would you like to be reminded of anything else?");
                Console.WriteLine("Y/N");
                char answer2 = Convert.ToChar(Console.ReadLine());
                if (answer2 == 'N')
                {
                    Console.WriteLine("Your alarm has been set!");
                    Console.WriteLine("Would you like to see previous reminders?");
                    Console.WriteLine("Y/N");
                    char viewreminder = Convert.ToChar(Console.ReadLine());
                    if (viewreminder == 'N')
                    {
                        Console.WriteLine("Thank you so much for using our app!");
                    }
                    else
                    {
                        Console.WriteLine("Your reminders are set for: " + remind1 + " Month: " + month1 + " Day: " + day1 + " Year: " + year1);
                    }
                }
                else
                {
                    Console.WriteLine(" Please type what you would like to remember");
                    Console.WriteLine("Example: Remind me to buy Christmas gift");

                    string remind3 = Console.ReadLine();


                    //Saves month as a value
                    Console.WriteLine("Please enter the month you would like to be reminded on");
                    Console.WriteLine("Jan/Feb/Mar/Apr/May/June/Jul/Aug/Sep/Oct/Nov/Dec");

                    string month3 = Convert.ToString(Console.ReadLine());

                    //saves day as a value
                    Console.WriteLine("Please enter the day you would like to be reminded on");
                    Console.WriteLine("1-31");

                    int day3 = Convert.ToInt32(Console.ReadLine());

                    //saves year as a value
                    Console.WriteLine("Please enter the year you like to be reminded on");
                    Console.WriteLine("2000-2030");

                    int year3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Reminder 3 : " + remind3);
                    Console.WriteLine("Month it will be held on : " + month3);
                    Console.WriteLine("Day it will be held on : " + day3);
                    Console.WriteLine("Year it will be held on : " + year3);

                    Console.WriteLine("Would you like to see previous reminders?");
                    Console.WriteLine("Y/N");
                    char viewreminder2 = Convert.ToChar(Console.ReadLine());
                    if (viewreminder2 == 'N')
                    {
                        Console.WriteLine("Your alarm has been set!");
                    }
                    else
                    {
                        Console.WriteLine("Your reminders are set for: " + remind1 + " Month: " + month1 + " Day: " + day1 + " Year: " + year1);
                        Console.WriteLine("Your reminders are set for: " + remind2 + " Month: " + month2 + " Day: " + day2 + " Year: " + year2);
                    }

                }
            }
        }
    }
}
