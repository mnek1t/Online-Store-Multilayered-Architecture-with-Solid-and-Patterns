using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Helpers
{
    internal static class InputHelper
    {
        public static UserModel ReadRegistration()
        {
            var id = 0;
            Console.WriteLine("Input first name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Input last name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Input login");
            var login = Console.ReadLine();
            Console.WriteLine("Input login");
            var password = Console.ReadLine();
            var roleId = 2;
            return new UserModel(id, firstName, lastName, login, password, roleId);
        }
        public static CategoryModel ReadCategoryModel()
        {
            throw new NotImplementedException();
        }

        public static ManufacturerModel ReadManufacturerModel()
        {
            throw new NotImplementedException();
        }

        public static OrderStateModel ReadOrderStateModel()
        {
            Console.WriteLine("Input State Id");
            var id=int.Parse(Console.ReadLine());
            Console.WriteLine("Input State Name");
            var name = Console.ReadLine();
            return new OrderStateModel(id,name);
            //throw new NotImplementedException();
        }

        public static UserRoleModel ReadUserRoleModel()
        {
            Console.WriteLine("Input User Role Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input User Role Name");
            var name = Console.ReadLine();
            return new UserRoleModel(id, name);
            //throw new NotImplementedException();
        }
    }
}
