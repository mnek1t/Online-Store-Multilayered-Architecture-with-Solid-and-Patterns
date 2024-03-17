using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class UserModel : AbstractModel
    {
        public UserModel(int id, string firstName, string lastName, string login, string password, int roleId) : base(id)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Password = password;
            this.RoleId = roleId;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} {FirstName} {LastName} {Login}";
        }
    }
}
