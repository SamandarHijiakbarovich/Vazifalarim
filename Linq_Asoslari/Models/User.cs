using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Asoslari.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        public int CarId { get; set; }
        public string PhonNumber { get; set; }

        public bool Equals(User user1,User user2)
        {
            return (user1.FirstName == user2.FirstName &&
                user1.LastName == user2.LastName && 
                user1.PhonNumber == user2.PhonNumber);
        }

        public int GetHashCode(User obj)
        {
            if(obj is null)
            {
                return 0;
               
            }
            int IdHashCode = obj.Id.GetHashCode();
            int NameHashCode = obj.FirstName is null ? 0 : obj.FirstName.GetHashCode();
            return IdHashCode ^ NameHashCode;
        }


    }
}
