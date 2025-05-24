using System;

class Program
{
    static void Main(string[] args)
    {
        string still = "yes";
        do
        {
            Console.WriteLine("If you wat a specific escripture, write the reference of thr scripture, is not, let the space in blank: ");
            string reference = Console.ReadLine();
            Console.WriteLine("If you wat a specific escripture, write the fist verse, is not, let the space in blank: ");
            string enteredScripture = Console.ReadLine();
            if (reference != "")
            {
                string enteredVers = "null";
                Console.WriteLine("If the scripture have anoer verse, write the verse, is not, let the space in blank: ");
                enteredVers = Console.ReadLine();
                if (enteredVers == "null")
                {
                    Console.Clear();
                    Random random = new Random();
                    int randomNumber = random.Next(21);
                    Reference A = new Reference(randomNumber, reference);
                    Scripture B = new Scripture(randomNumber, enteredScripture);
                    string scripture = B.GetScripture();
                    Words C = new Words(scripture);
                    Console.Write($"{A.GetReference()}");
                    C.Prove();
                    string Answer = "no";
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    Answer = Console.ReadLine();
                    Console.Clear();
                    do
                    {
                        int cronometer = 0;
                        Console.Write($"{A.GetReference()}");
                        do
                        {
                            C.ProveRemove();
                            cronometer = cronometer + 1;
                        } while (cronometer != 3);
                        C.Prove();
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                        Answer = Console.ReadLine();
                        Answer = C.StatusAnalisis();
                        Console.Clear();
                    } while (Answer != "quit");
                }

                if (enteredVers != "null")
                {
                    Console.Clear();
                    Random random = new Random();
                    int randomNumber = random.Next(21);
                    Reference A = new Reference(randomNumber, reference);
                    Scripture B = new Scripture(randomNumber, enteredScripture, enteredVers);
                    string scripture = B.GetScripture();
                    Words C = new Words(scripture);
                    Console.Write($"{A.GetReference()}");
                    C.Prove();
                    string Answer = "no";
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    Answer = Console.ReadLine();
                    Console.Clear();
                    do
                    {
                        int cronometer = 0;
                        Console.Write($"{A.GetReference()}");
                        do
                        {
                            C.ProveRemove();
                            cronometer = cronometer + 1;
                        } while (cronometer != 3);
                        C.Prove();
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                        Answer = Console.ReadLine();
                        Answer = C.StatusAnalisis();
                        Console.Clear();
                    } while (Answer != "quit");
                }
            }
            else
            {
                Console.Clear();
                Random random = new Random();
                int randomNumber = random.Next(21);
                Reference A = new Reference(randomNumber);
                Scripture B = new Scripture(randomNumber);
                string scripture = B.GetScripture();
                Words C = new Words(scripture);
                Console.Write($"{A.GetReference()}");
                C.Prove();
                string Answer = "no";
                Console.WriteLine("");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                Answer = Console.ReadLine();
                Console.Clear();
                do
                {
                    int cronometer = 0;
                    Console.Write($"{A.GetReference()}");
                    do
                    {
                        C.ProveRemove();
                        cronometer = cronometer + 1;
                    } while (cronometer != 3);
                    C.Prove();
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    Answer = Console.ReadLine();
                    Answer = C.StatusAnalisis();
                    Console.Clear();
                } while (Answer != "quit");
            }
            Console.WriteLine("You want to lear anoter scripture, tipe yes if you wat or not if you not want:");
            still = Console.ReadLine();
        } while (still != "not");
    }
}