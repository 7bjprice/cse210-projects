using System;
// written by Bryson and Troy
class Program
{
    static void Main(string[] args)
    {

        ReadWrite readwrite = new();
        bool exit = false;

        string reference = "Helaman 5:11-12";
        Scripture myScripture = new Scripture(reference, "11 And he hath power given unto him from the Father to redeem them from their sins because of repentance; therefore he hath sent his angels to declare the tidings of the conditions of repentance, which bringeth unto the power of the Redeemer, unto the salvation of their souls.\n\n12 And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        //Main menu
        Console.Clear();
        do
        {
            Console.WriteLine("Welcome to the scrpture memorizer program.\n 1. Memorize a verse\n 2. Add a new verse\n 3. Choose a different verse\n 4. Exit");
            string action = Console.ReadLine();
            if (action == "1")
            {
                myScripture.Display();
                do//Repeat this until the user chooses to exit
                {

                    Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
                    string userInput = Console.ReadLine();
                    if (userInput == "")
                    {
                        Console.Clear();
                        if (myScripture.HideWords(3) == true)
                        {
                            myScripture.Display();
                            exit = true;
                            break;
                        }
                        myScripture.Display();
                    }

                    else if (userInput == "quit")
                    {
                        exit = true;
                    }
                } while (!exit);
            }
            else if (action == "2")
            {
                Console.WriteLine("Please type in the scripture refernce:");
                string refernce = Console.ReadLine();
                Console.WriteLine("Please paste in the scripture verses:");
                string verses = Console.ReadLine();
                Console.WriteLine("Please type the name of the file you would like to add this too:");
                string newFileName = Console.ReadLine();
                readwrite.WriteScripture(refernce, verses, newFileName);
            }
            else if (action == "3")
            {
                Console.WriteLine("Please type the file name");
                string fileName = Console.ReadLine();
                Console.WriteLine("Please type the verse reference");
                string newReference = Console.ReadLine();
                string scripture = readwrite.GetScripture(fileName, newReference);
                myScripture = new Scripture(newReference, scripture);
            }
            else if (action == "4")
            {
                exit = true;
            }
        } while (!exit);
    }
}
