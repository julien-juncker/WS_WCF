using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculationClient client = new CalculationClient();
            int i = 2, j = 3;
            int result = client.m_add(i, j);
            Console.WriteLine(result);

            client.Close();
        }
    }
}
