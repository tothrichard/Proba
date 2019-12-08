using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace OLVAS
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader olvas = new StreamReader("RULES.txt", Encoding.Default);
            string szoveg;
            while (!olvas.EndOfStream)
            {
                szoveg = olvas.ReadLine();
                Console.WriteLine(szoveg);
            }
           
            olvas.Close();
            Console.ReadLine();
        }
    }
}
