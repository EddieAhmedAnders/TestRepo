using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Main program = new Main();
            program.MainProgram();
        }
    }

    public class Main
    {
        public void MainProgram()
        {
            string text = "Testing testing ";
            int x = 1;
            int y = 2;
            int z = 3;

            Console.WriteLine(text + x +" "+y+" "+z+"!");
            Console.ReadLine();

            Console.WriteLine(User.test(x, y, z));
            Console.ReadLine();
        }
    }
}
