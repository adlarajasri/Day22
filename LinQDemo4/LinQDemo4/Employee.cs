using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo4
{
    public class Employee
    {
        private string _name;

        private string _city;

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        public string City

        {

            get { return _city; }

            set { _city = value; }

        }

        public Employee(string name, string city)

        {

            _name = name;

            _city = city;

        }

    }
}

