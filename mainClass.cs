using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab_Project
{
    internal class mainClass
    {
        static Stack<Team> teams = new Stack<Team>();
        static LinkedList<Match> upcoming = new LinkedList<Match>();
        static LinkedList<Match> previous = new LinkedList<Match>();
        static void Main(string[] args)
        {
            if(teams.Count == 0)
                setTeams();
            Console.Clear();
            printHeader("Welcome to CricTime");
            
            Console.WriteLine("Select an Option:");
            Console.WriteLine("\n1: List Teams");
            Console.WriteLine("2: Previous PSL Matches");
            Console.WriteLine("3: Upcoming PSL Matches");
            Console.WriteLine("4: Exit");

            int choice;

            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > 4);
            

            switch (choice)
            {
                case 1:
                    listTeams();
                    break;

                case 2:
                    previousMatches();
                    break;

                case 3:
                    upcomingMatches();
                    break;

                case 4:
                    break;
            }

        }
        
        static void setTeams()
        {
            Team karachi = new Team("Karachi Kings", "Imad Wasim", "Salman Iqbal");
            Team peshawer = new Team("Peshawer Zalmi", "Wahab Riaz", "Javaid Afridi");
            Team lahore = new Team("Lahore Qalanders", "Shaheen Shah Afridi", "Fawad Rana");
            Team islamabad = new Team("Islamabad United", "Shadab Khan", "Ali Naqvi");
            Team multan = new Team("Multan Sultans", "Rizwan", "Ali Tareen");
            Team queta = new Team("Queta Gladiators", "Sarfraz Ahmed", "Nadeem");

            teams.Push(karachi);
            teams.Push(peshawer);
            teams.Push(lahore);
            teams.Push(islamabad);
            teams.Push(multan);
            teams.Push(queta);
        }

        static void setUpcomingMatches()
        {
            Score n = new Score(0, 0, 0, 0);
            Match newMatch = new Match(teams.ElementAt(1), teams.ElementAt(2), n, n, "Karachi", 2023, 02, 18, 01, 30);
            upcoming.AddLast(newMatch);
            newMatch = new Match(teams.ElementAt(2), teams.ElementAt(4), n, n, "Karachi", 2023, 02, 19, 01, 30);
            upcoming.AddLast(newMatch);
            
        }

        static void upcomingMatches()
        {
            Console.Clear();
            printHeader("Upcoming Matches");
            if(upcoming.Count == 0)
                setUpcomingMatches();
            
            foreach(Match match in upcoming)
            {
                match.matchCard();
            }

            Console.WriteLine("\nTo Search for a specific team Matches Enter Team:");
            Console.WriteLine("Karachi Kings, Lahore Qalanders, Islamabad United, Multan Sultans, Peshawer Zalmi");
            Console.WriteLine("1 to return back to main menu");
            string toSearch = Console.ReadLine();
            if(toSearch != "1")
            {
                searchMatches(upcoming, toSearch);
            }
            Main(null);
        }

        static void searchMatches(LinkedList<Match> list, String toSearch)
        {
            LinkedList<Match> newList = new LinkedList<Match>();
            Console.Clear();
            printHeader("Search: " + toSearch);
            foreach (Match match in list)
            {
                if (match.team1.getTeamName() == toSearch || match.team2.getTeamName() == toSearch)
                {
                    newList.AddLast(match);
                }
            }  
            if(newList.Count != 0)
            {
                foreach(Match newMatch in newList)
                {
                    newMatch.matchCard();
                }
            }
            else
            {
                Console.WriteLine("No Search Result Found");
            }

            Console.WriteLine("\nPress any key to go back to the main menu");
            Console.ReadLine();
            Main(null);
        }

        static void setPreviousMatches()
        {
            Score s1 = new Score(180, 5, 20.0, 20.0), s2 = new Score(138, 10, 19.3, 20.0);// Runs, Wickets, Overs, Total Overs
            Match newMatch = new Match(teams.ElementAt(2), teams.ElementAt(4), s1, s2, "Karachi", 2022, 02, 19, 01, 30);
            previous.AddLast(newMatch);
            s1 = new Score(196, 5, 20.0, 20.0);
            s2 = new Score(170, 5, 19.3, 20.0);
            newMatch = new Match(teams.ElementAt(1), teams.ElementAt(3), s1, s2, "Karachi", 2022, 02, 18, 01, 30);
            previous.AddLast(newMatch);
            
        }

        static void previousMatches()
        {
            Console.Clear();
            printHeader("Previous Matches");
            if (previous.Count == 0)
                setPreviousMatches();

            foreach (Match match in previous)
            {
                match.previousMatchCard();
            }

            Console.WriteLine("\nTo Search for a specific team Matches Enter Team:");
            Console.WriteLine("Karachi Kings, Lahore Qalanders, Islamabad United, Multan Sultans, Peshawer Zalmi");
            Console.WriteLine("1 to return back to main menu");
            string toSearch = Console.ReadLine();
            if (toSearch != "1")
            {
                searchMatches(previous,toSearch);
            }
            Main(null);
        }
        static void listTeams()
        {
            Console.Clear();
            
            printHeader("List of all Teams");

            foreach (Team team in teams)
            {
                Console.WriteLine("\n" + team.getTeamName());
                Console.WriteLine("\tTeam Captain: " + team.getCaptainName());
                Console.WriteLine("\tTeam Owner: " + team.getOwnerName());
            }

            Console.WriteLine("\n\nPress Enter to return back to the main menu");
            Console.ReadLine();
            Console.Clear();
            Main(null);
        }
        static void printHeader(string title)
        { 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("|                                                   |");
            int spaces = 54 - title.Length;
            spaces = spaces / 2;
            string newtitle = "";
            for (int i = 0; i < spaces; i++)
            {
                if (i == 0)
                    newtitle += "*";
                else
                    newtitle += " ";
            }
            newtitle += title;
            for (int i = 1; i < spaces - 1; i++)
                newtitle += " ";

            if (newtitle.Length < 52)
                newtitle += " *";

            else
                newtitle += "*";

            Console.WriteLine(newtitle);
            Console.WriteLine("|                                                   |");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
        }
    }
}
