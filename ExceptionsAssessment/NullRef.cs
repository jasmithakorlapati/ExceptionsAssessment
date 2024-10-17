using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssessment
{
    public class NullRef
    {
        public static void Main(string[] args)
        {
            string a = "";
            try
            {
                int len = a.Length;
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
