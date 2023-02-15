using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab_Project
{
    internal class Score
    {
        public int runs, wickets;
        public double overs, totalOvers;
        
        public Score(int runs, int wickets, double overs, double totalOvers)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.overs = overs;
            this.totalOvers = totalOvers;
        }
    }
}
