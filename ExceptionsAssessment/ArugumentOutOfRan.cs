using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssessment
{
    public class ArugumentOutOfRan
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>{ 1, 2, 3 };
            try
            {
                int res = list[9];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
}
