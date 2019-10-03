using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieOfRatings
{

        public class Review
        {
            public int Reviewer { get; set; }
            public int Movie { get; set; }
            public int Grade { get; set; }
            public string Date { get; set; }
        }

}
