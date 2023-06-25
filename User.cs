using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseProject
{
    public class User
    {
        private string name;
        private string lastname;
        private string university;

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string University { get => university; set => university = value; }

        public User(){}
        public User(string name, string lastname, string university)
        {
            Name = name;
            Lastname = lastname;
            University = university;
        }
    }
}
