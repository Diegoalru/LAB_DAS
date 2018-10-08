using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.App_Code
{
    public class StudentC
    {
        //Person person = new Person();
        IFormatIdAndName formatter;
        IDataAccess da;

        public StudentC (IFormatIdAndName _formatter, IDataAccess da)
        {
             this.formatter = _formatter;
            this.da = da;
        }

        public string FormatNameAndID(string name, int id)
        {
            return formatter.FormatNameAndID(name, id);
        }

        public void Add(StudentC student)
        {
            Console.WriteLine(student.)
        }

    }
    
    //class Composition{}
}
