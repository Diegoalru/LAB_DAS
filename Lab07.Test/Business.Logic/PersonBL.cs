using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PersonBL
    {

        List<Person> people = new List<Person>();

        public void Create(Person person)
        {
            if (string.IsNullOrEmpty(person.Name))
                throw new ArgumentException("Name cannot be empty.");
                people.Add(person);
            
        }

        /// <summary>
        ///  Finds the one item with same id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetById(int id)
        {
            foreach (var item in people)    
            {
                if (item.Id == id) return item;
            }
            return null;
        }
    }
}
