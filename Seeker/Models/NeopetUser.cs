using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeker.Models
{
    [Serializable]
    public class NeopetUserList
    {
        public List<NeopetUser> Users { get; set; }

        public NeopetUserList() { Users = new System.Collections.Generic.List<NeopetUser>(); }
    }

    [Serializable]
    public class NeopetUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public NeopetUser(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }
    }
}
