using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssessment
{
    public class IndexOutOfRan
    {
        public static void Main(String[] args)
        {
            int[] a = { 1, 2, 3 };
            string b = "";
            try
            {
                int last = b[8];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
