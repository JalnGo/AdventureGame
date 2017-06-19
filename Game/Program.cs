using System;

namespace Game
{
    class Program
    {

        public string Run { get; set; }
        public string Hide { get; set; }

        public void Display(string Hide)
        {
            Hide = "game over";
            Console.WriteLine("game over message");
        }

        public void Displays(string Run)
        {
            Run = "continue game";
            Console.WriteLine("continue game message");
        }

        //
        //
        //

        static void Main(string[] args)
        {
            Console.WriteLine("Forewarning, you're abt to run for your life. \nIn every situation there are two options: 1 - hide and 2 - run. CHOOSE WISELY!!!");
            Console.WriteLine("Press Enter key to continue...");
            Console.ReadLine();

            Console.WriteLine("Walking the late night streets alone, you encounter a distorted being charging in your direction. \nHe's yelling and carrying a blade... I think you should start running now!!! ");
            Console.WriteLine("Press Enter key to START...");
            Console.ReadLine();

            Console.WriteLine("THE SCREAMER IS AFTER YOU!!!!! You're running down a dark empty street. \nNotice the parked car over over to the right up there.");
            Console.WriteLine("Do you choose hide or run?");
            string userChoice1 = Console.ReadLine();

            {
                if (userChoice1 == "hide")
                {
                    Console.WriteLine("Smh, he got you. Should've stayed on your feet..");
                    Console.WriteLine("Game over!");
                }
                else if (userChoice1 == "run")
                {
                    Console.WriteLine("Good idea. Keep moving buddy.");
                }

                Console.WriteLine("Press Enter key to continue...");
                Console.ReadLine();

            }
            //
            //
            //
            Console.WriteLine("You've made a right turn onto another different street. Notice the vacant house to the left.");
            Console.WriteLine("Will this guy ever get tried!?");
            Console.WriteLine("Do you choose hide or run?");
            string userChoice2 = Console.ReadLine();

            {
                if (userChoice2 == "hide")
                {
                    Console.WriteLine("Not sure why you thought he wouldn't follow you in there...");
                    Console.WriteLine("Game over!");
                }
                else if (userChoice2 == "run")
                {
                    Console.WriteLine("Of course! No one ever makes it out the house.");
                }

                Console.WriteLine("Press Enter key to continue...");
                Console.ReadLine();
            } 

            //
            //
            //

            Console.WriteLine("Hey, there's the park! Hopefully you can lose him in the trees...");
            Console.WriteLine("Do you choose hide or run?");
            string userChoice = Console.ReadLine();

            {
                if (userChoice == "hide")
                {
                    Console.WriteLine("Did you really try to hide behind that tree though?");
                    Console.WriteLine("Game over!");
                }
                else if (userChoice == "run")
                {
                    Console.WriteLine("Good because I think he can still see you behind some trees.");
                }

                Console.WriteLine("Press Enter key to continue...");
                Console.ReadLine();
            }
            //
            //
            //
            Console.WriteLine("There's another person! Hopefully they're not crazy too.");
            Console.WriteLine("Do you choose hide or run?");
            string userChoice3 = Console.ReadLine();
            {
                if (userChoice3 == "hide")
                {
                    Console.WriteLine("Now both of you are dead.");
                    Console.WriteLine("Game over!");
                }
                else if (userChoice3 == "run")
                {
                    Console.WriteLine("If they were smart, they would too.");
                }

                Console.WriteLine("Press Enter key to continue...");
                Console.ReadLine();
            }
            //
            //
            //
            Console.WriteLine("The Screamer's killing the other person!!!!!");
            Console.WriteLine("Do you choose hide or run?");
            string userChoice4 = Console.ReadLine();
            {
                if (userChoice4 == "hide")
                {
                    Console.WriteLine("You though he forgot about you?");
                    Console.WriteLine("Game over!");
                }
                else if (userChoice4 == "run")
                {
                    Console.WriteLine("They should've ran too.");
                }

                Console.WriteLine("Press Enter key to continue...");
                Console.ReadLine();
            }



















            Console.ReadLine();
        }
    }
}