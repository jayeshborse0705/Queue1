using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue(56);
            qt.Enqueue(30);
            qt.Enqueue(70);


            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("The number of elements in the Queue " + qt.Count);
            Console.WriteLine("Does the Queue contain " + qt.Contains(3));

            Console.ReadKey();
        }
    }
}