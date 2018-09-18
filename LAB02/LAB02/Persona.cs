using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    public class Persona : ILogger
    {

        #region Variables
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Construtores
        public Persona()
        {}
        
        public Persona(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        #endregion

        #region Metodos
        public void Log(string log)
        {
            Console.WriteLine("Using logger.");
        }
        #endregion

    }
}
