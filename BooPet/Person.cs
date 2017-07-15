using System;
using System.Collections.Generic;
using System.Text;

namespace BooPet
{
    internal class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _dataType;

        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        public Person(string name,string dataType)
        {
            _name = name;
            _dataType = dataType;
        }
    }
}
