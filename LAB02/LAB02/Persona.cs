using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    public class Persona
    {

        #region Variables
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        #endregion

        
        public Persona()
        {}
        

        public Persona(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        

    }
}
