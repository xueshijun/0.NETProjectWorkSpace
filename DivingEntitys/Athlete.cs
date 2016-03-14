using System;
using System.Collections.Generic;
using System.Text;

namespace Entitys
{
    public class Athlete : User
    {
        private string parameter;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Role
        {
            get { return "athlete"; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Parameter
        {
            get { return parameter; }
            set { parameter = value; }
        }
    }
}
