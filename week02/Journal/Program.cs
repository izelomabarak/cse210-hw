using System;
using System.Threading.Tasks.Dataflow;
// I add the opportunity of give a more detailed description of you, your name and hobbies or activities that you do.

class Program
{
    static void Main(string[] args)
    {
        string end = "null";
        int choise = 0;
        string entry = "0";
        Write newEntry = new Write();
        Save newFile = new Save();
        Open openFile = new Open();
        List<string> text = new List<string>();
        do
        {
            Console.WriteLine("Wealcome to your Journal Please select one of the following choises:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please select one of the following choises:");
            string guess = Console.ReadLine();
            choise = int.Parse(guess);

            if (choise == 1)
            {
                newEntry.WriteEntry();
                entry = newEntry._entry;
                text.Add(entry);
            }

            else if (choise == 2)
            {
                foreach (string i in text)
                {
                    Console.WriteLine(i);
                }
            }

            else if (choise == 3)
            {
                Console.WriteLine("What is the name of the file: ");
                string fileNameOpen = Console.ReadLine();
                openFile._fileNameOpen = fileNameOpen;
                openFile.ReadFile();
            }

            else if (choise == 4)
            {
                Console.WriteLine("What is the name of the file: ");
                string fileName = Console.ReadLine();
                newFile._fileName = fileName;
                newFile._text = text;
                newFile.WriteFile();
                Console.WriteLine("File Created");
            }

            else if (choise == 5)
            {
                end = "yes";
                Console.WriteLine("Tanks for use our Journal");
            }

        } while (end != "yes");
    }
}