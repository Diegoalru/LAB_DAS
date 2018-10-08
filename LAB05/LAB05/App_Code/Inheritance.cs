using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.App_Code
{
    public class Person : IFormatIdAndName
    {
        public virtual string FormatNameAndID(string name, int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.Append(name);
            sb.Append(", ID: ");
            sb.Append(id);
            return sb.ToString();
        }
    }

    public class Student : Person
    {

    }

    /* class Inheritance {} */

}
