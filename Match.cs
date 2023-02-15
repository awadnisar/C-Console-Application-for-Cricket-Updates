using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab_Project
{
    internal class Match
    {
        public Team team1, team2;
        private Score team1Score, team2Score;
        private String location;
        private int year, month, day, hour, minute;
        
        public Match(Team team1, Team team2, Score t1, Score t2, String location, 
            int year, int month, int day, int hour = 05, int minutes = 30)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.team1Score = t1;
            this.team2Score = t2;
            this.location = location;
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minutes;
        }

        private string splitName(String n)
        { 
            var s1 = n.Split(' ')[0];
            var s2 = n.Split(' ')[1];
            var res = s1.Substring(0, 1);
            res += s2.Substring(0, 1);
            
            return res;
        }
        public void matchCard()
        {   
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            string T1 = splitName(team1.getTeamName()), T2 = splitName(team2.getTeamName());

            
            Console.WriteLine("\n=======================================");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=           "+T1 +"    vs    "    +T2+"            =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=       Match Date: "+day.ToString("D2")+"-"+month.ToString("D2")+"-"+year+"        =");
            Console.WriteLine("=          Match Time: "+hour.ToString("D2")+":"+minute.ToString("D2")+"          =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=======================================");


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void previousMatchCard()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            string T1 = splitName(team1.getTeamName()), T2 = splitName(team2.getTeamName());


            Console.WriteLine("\n=======================================");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=           " + T1 + "    vs    " + T2 + "            =");
            Console.WriteLine("=         " + team1Score.runs.ToString("D3") + "/"+team1Score.wickets.ToString("D2")+ "      " + team2Score.runs.ToString("D3") + "/" + team2Score.wickets.ToString("D2") +"          =");
            Console.WriteLine("=       " + team1Score.overs.ToString("00.0") + "("+team1Score.totalOvers.ToString("00.0")+")" + "  " + team2Score.overs.ToString("00.0") + "(" + team2Score.totalOvers.ToString("00.0") + ")" + "        =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=       Match Date: " + day.ToString("D2") + "-" + month.ToString("D2") + "-" + year + "        =");
            Console.WriteLine("=          Match Time: " + hour.ToString("D2") + ":" + minute.ToString("D2") + "          =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=======================================");


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
