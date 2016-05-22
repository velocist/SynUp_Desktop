using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.model.pojo
{
    public partial class TeamMember
    {
        private String nif;
        private String name;
        private String surname;
        private System.DateTime entrance;

        public TeamMember(string nif, string name, string surname, DateTime entrance)
        {
            Nif = nif;
            Name = name;
            Surname = surname;
            Entrance = entrance;
        }

        public string Nif
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public DateTime Entrance
        {
            get
            {
                return entrance;
            }

            set
            {
                entrance = value;
            }
        }
    }

}
