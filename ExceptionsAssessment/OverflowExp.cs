using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssessment
{
    public class OverflowExp
    {
        public static void Main(string[] args)
        {
            int max = int.MaxValue;
            try
            {
               
               int a = max+1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
