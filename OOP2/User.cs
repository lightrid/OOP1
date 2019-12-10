using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class User
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        private String email;
        public String Email
        { 
            get { return email; }
            set { email = value; }
        }

        private String password;
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public static List<String> types = new List<String>
        {
            "Worker","Shop"
        };

        private String type;
        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public User()
        {

        }

        public User(int id, String email, String password, String type)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.type = type;

        }

    }
}
