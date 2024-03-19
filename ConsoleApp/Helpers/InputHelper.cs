using StoreBLL.Models;
using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        }
        public static ProductModel ReadProductModel() 
        {
            Console.WriteLine("Input User Role Id");
            var id = int.Parse(Console.ReadLine());
            ProductTitleModel productTitleModel = ReadProductTitleModel();
            Console.WriteLine("Input Description");
            var description = Console.ReadLine();
            Console.WriteLine("Input Price");
            var price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input Manufacturer Id");
            var manufacturer = int.Parse(Console.ReadLine());
            
            return new ProductModel(id, productTitleModel.Id, manufacturer, description,price);
        }
        public static ProductTitleModel ReadProductTitleModel() 
        {
            Console.WriteLine("Input Product Title Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Name");
            var name = Console.ReadLine();
            Console.WriteLine("Input Category");
            var category = int.Parse(Console.ReadLine());
            return new ProductTitleModel(id, name, category);
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
