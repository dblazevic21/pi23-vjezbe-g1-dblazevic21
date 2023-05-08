using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManager
{
    public class Activity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int MaxPoints { get; set; }

        public int MinPointsForGrade { get; set; }

        public int MinPointsForSignature { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
