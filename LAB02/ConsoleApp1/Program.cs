using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB02;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person");

              //ILogger logger = new Persona();

              //LAB v1
              Persona p = new Persona();
              p.Id = 1;
              p.Name = "Diego";
              p.LastName = "Rubi";


            /* //LAB v2
             * Persona p = new Persona(1, "Diego", "Rubi");
             */

            /* //LAB v3
             * Persona p = new Persona
             * {
             * Id = 1,
             * Name = "Diego",
             * LastName = "Rubí"
             * };
             */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            ILogger logger = p;

            String personString = string.Format("ID: {0}, Name: {1} and Last Name: {2}.", p.Id, p.Name, p.LastName);

            //Console.WriteLine(personString);
            logger.Log(personString);
            
            Console.ReadKey();
        }
    }
}
