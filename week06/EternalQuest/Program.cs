using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool follow = false;
        GoalManager start = new GoalManager();
        List<string> goals = start.GetGoals();
        goals.Add(start.GetScore().ToString());
        do
        {
            int choise = start.DisplayStart(goals[0]);
            if (choise == 1)
            {
                string added = "";
                int selection = start.CreateGoal();
                Console.WriteLine("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string descripton = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                string pointsString = Console.ReadLine();
                int points = int.Parse(pointsString);
                if (selection == 1)
                {
                    SimpleGoal newGoal = new SimpleGoal(name, descripton, points);
                    string tipe = "SimpleGoal";
                    added = newGoal.GetDetailsString(tipe);
                }

                else if (selection == 2)
                {
                    EternalGoal newGoal = new EternalGoal(name, descripton, points);
                    string tipe = "EternalGoal";
                    added = newGoal.GetDetailsString(tipe);
                }

                else if (selection == 3)
                {
                    ChecklistGoal newGoal = new ChecklistGoal(name, descripton, points, 1, 0);
                    string tipe = "ChecklistGoal";
                    added = newGoal.GetDetailsString(tipe);
                }
                goals.Add(added);
            }

            else if (choise == 2)
            {
                int num = 1;
                foreach (string task in goals)
                {
                    if (task != goals[0])
                    {
                        List<string> information;
                        char U = '.';
                        string[] words = task.Split(U);
                        information = words.ToList();
                        if (information[0] == "ChecklistGoal")
                        {
                            bool end = false;
                            if (information[6] == information[5])
                            {
                                end = true;
                            }
                            ChecklistGoal goal2 = new ChecklistGoal(information[1], information[2], int.Parse(information[3]), int.Parse(information[5]), int.Parse(information[6]));
                            goal2.GetRepresentationString(num, end.ToString());
                            num = num + 1;
                        }

                        else if (information[0] == "SimpleGoal")
                        {
                            SimpleGoal goal2 = new SimpleGoal(information[1], information[2], int.Parse(information[3]));
                            goal2.GetRepresentationString(num, information[4]);
                            num = num + 1;
                        }

                        else if (information[0] == "EternalGoal")
                        { 
                            Goal goal2 = new Goal(information[1], information[2], int.Parse(information[3]));
                            string eternal = "False";
                            goal2.GetRepresentationString(num, eternal);
                            num = num + 1;
                        }
                    }
                }
            }

            else if (choise == 3)
            {
                start.SaveGoals(goals);
            }

            else if (choise == 4)
            {
                goals = start.LoadGoals();
            }

            else if (choise == 5)
            {
                int num = 1;
                foreach (string task in goals)
                {
                    if (task != goals[0])
                    {
                        string a = task.ToString();
                        List<string> i;
                        char u = '.';
                        string[] w = a.Split(u);
                        i = w.ToList();
                        Goal goal1 = new Goal(i[1], i[2], int.Parse(i[3]));
                        goal1.GetSareString(num);
                        num = num + 1;
                    }
                }
                Console.WriteLine("Which goal did you accomplish? ");
                string accomplish = Console.ReadLine();
                int end = int.Parse(accomplish);
                string value = goals[end];
                string goal = value.ToString();
                List<string> information;
                char U = '.';
                string[] words = goal.Split(U);
                information = words.ToList();
                if (information[0] == "SimpleGoal")
                {
                    bool fulfite = bool.Parse(information[4]);
                    if (fulfite == true)
                    {
                        Console.WriteLine("You already finis this goal.");
                    }

                    else
                    {
                        SimpleGoal succede = new SimpleGoal(information[1], information[2], int.Parse(information[3]));
                        bool archive = succede.IsComplete();
                        Console.WriteLine($"Congratulations! You have earned {information[3]} points");
                        int previusScore = int.Parse(goals[0]);
                        int scoreEarned = int.Parse(information[3]);
                        int newScore = previusScore + scoreEarned;
                        Console.WriteLine($"You now have {newScore} points");
                        goals[0] = newScore.ToString();
                        information[4] = archive.ToString();
                        string goalFulfite = succede.GetCompliteString(information[0], information[1], information[2], information[3], information[4]);
                        goals[end] = goalFulfite;
                    }
                }

                if (information[0] == "EternalGoal")
                {
                    EternalGoal succede = new EternalGoal(information[1], information[2], int.Parse(information[3]));
                    Console.WriteLine($"Congratulations! You have earned {information[3]} points");
                    int previusScore = int.Parse(goals[0]);
                    int scoreEarned = int.Parse(information[3]);
                    int newScore = previusScore + scoreEarned;
                    Console.WriteLine($"You now have {newScore} points");
                    goals[0] = newScore.ToString();
                }

                if (information[0] == "ChecklistGoal")
                {
                    bool fulfite = false;
                    if (information[5] == information[6])
                    {
                        fulfite = true;
                    }
                    ChecklistGoal succede = new ChecklistGoal(information[1], information[2], int.Parse(information[3]), int.Parse(information[5]), int.Parse(information[6]));
                    int times = int.Parse(information[6]);
                    bool archive = succede.IsComplete();
                    if (fulfite == true)
                    {
                        Console.WriteLine("You already finis this goal.");
                    }
                    else
                    {
                        int scoreEarned = 0;
                        if (archive == true)
                        {
                            times = times + 1;
                            scoreEarned = int.Parse(information[3]);
                            if (times == int.Parse(information[5]))
                            {
                                scoreEarned = int.Parse(information[3]) + int.Parse(information[4]);

                            }
                        }
                        Console.WriteLine($"Congratulations! You have earned {scoreEarned} points");
                        int previusScore = int.Parse(goals[0]);
                        int newScore = previusScore + scoreEarned;
                        Console.WriteLine($"You now have {newScore} points");
                        goals[0] = newScore.ToString();
                        string goalFulfite = succede.GetCompliteString(information[0], information[1], information[2], information[3], information[4], information[5], times.ToString());                       
                        goals[end] = goalFulfite;
                    }
                }
            }

            else if (choise == 6)
            {
                follow = start.Quit();
            }
        } while (follow == false);
    }
}