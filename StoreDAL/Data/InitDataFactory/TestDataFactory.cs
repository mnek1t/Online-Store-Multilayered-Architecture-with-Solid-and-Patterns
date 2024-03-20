using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Data.InitDataFactory
{
    public class TestDataFactory : AbstractDataFactory
    {
        public override Category[] GetCategoryData()
        {
            return new[]
            {
                new Category(1,"fruits"),
                new Category(2,"water"),
                new Category(3,"vegetables"),
                new Category(4,"seafood"),
                new Category(5,"meet"),
                new Category(6,"grocery"),
                new Category(7,"milk food"),
                new Category(8,"smartphones"),
                new Category(9,"laptop"),
                new Category(10,"photocameras"),
                new Category(11,"kitchen accesories"),
                new Category(12,"spices"),
                new Category(13,"Juice"),
                new Category(14,"alcohol drinks"),
            };
        }
        public override CustomerOrder[] GetCustomerOrderData()
        {
            return new[]
            {
                new CustomerOrder(1,"2024-03-17",2,1),
                new CustomerOrder(2,"2024-03-16",3,1)
            }; 
        }

        public override Manufacturer[] GetManufacturerData()
        {
            return new[]
            {
                new Manufacturer(1, "First manufacturer"),
                new Manufacturer(2, "Second manufacturer"),
                new Manufacturer(3, "Third manufacturer"),
                new Manufacturer(4, "Fourth manufacturer"),
                new Manufacturer(5, "Fifth manufacturer"),
                new Manufacturer(6, "Sixth manufacturer")
            };
        }
        public override OrderDetail[] GetOrderDetailData()
        {
            return new[] 
            {
                new OrderDetail(1,1,21,3.39m,2),
                new OrderDetail(1,2,8,6.00m,5)
            };
        }

        public override OrderState[] GetOrderStateData()
        {
            return new[]
            {
                new OrderState(1,"New Order"),
                new OrderState(2,"Cancelled by user"),
                new OrderState(3,"Cancelled by administrator"),
                new OrderState(4,"Confirmed"),
                new OrderState(5,"Moved to delivery company"),
                new OrderState(6,"In delivery"),
                new OrderState(7,"Delivered to client"),
                new OrderState(8,"Delivery confirmed by client")
            };
        }
        public override Product[] GetProductData()
        {
            return new[] 
            {
                new Product(1,1,1,"african banana", 1.69m),
                new Product(2,2,1,"royal gala", 3.70m),
                new Product(3,3,1,"mineral water", 2.50m),
                new Product(4,4,1,"netherlands tomato", 3.89m),
                new Product(5,5,1,"long cucumber", 7.90m),
                new Product(6,6,1,"baltic salmon", 22.90m),
                new Product(7,7,1,"russian pork", 6.00m),
                new Product(8,8,1,"ukrainian chicken", 6.00m),
                new Product(9,9,2,"cellophane paket", 0.05m),
                new Product(10,10,2,"holland cheese", 12.99m),
                new Product(11,11,2,"curd 9%", 0.69m),
                new Product(12,12,2,"Iphone 15 pro", 1566.69m),
                new Product(13,13,2,"Galaxy 22S", 1566.69m),
                new Product(14,14,3,"Asus 16gb", 899.69m),
                new Product(15,15,3,"HP 15033d", 599.69m),
                new Product(16,16,4,"Nikon 1239mgpx", 2599.69m),
                new Product(17,17,5,"Metal spoon", 15.69m),
                new Product(18,18,5,"Metal fork", 15.69m),
                new Product(19,19,5,"Metal knife", 15.69m),
                new Product(20,20,6,"chalky pepper", 0.39m),
                new Product(21,21,6,"ukrainian juice", 3.39m),
                new Product(22,22,6,"kozel", 2.39m)
            };
        }
        public override ProductTitle[] GetProductTitleData()
        {
            return new[] 
            {
                new ProductTitle(1,"Banana",1),
                new ProductTitle(2,"Apple",1),
                new ProductTitle(3,"Evian",2),
                new ProductTitle(4,"Tomato",3),
                new ProductTitle(5,"Cucumber",3),
                new ProductTitle(6,"Salmon",4),
                new ProductTitle(7,"Pork",5),
                new ProductTitle(8,"Chicken",5),
                new ProductTitle(9,"Paket",6),
                new ProductTitle(10,"Cheese",7),
                new ProductTitle(11,"Curd",7),
                new ProductTitle(12,"Iphone",8),
                new ProductTitle(13,"Samsung",8),
                new ProductTitle(14,"Asus",9),
                new ProductTitle(15,"HP",9),
                new ProductTitle(16,"Nikon",10),
                new ProductTitle(17,"Spoon",11),
                new ProductTitle(18,"Fork",11),
                new ProductTitle(19,"Knife",11),
                new ProductTitle(20,"Pepper",12),
                new ProductTitle(21,"Sadochok",13),
                new ProductTitle(22,"Beer",14)
            };
        }
        public override User[] GetUserData()
        {
            return new[] 
            {
                new User(1,"Mykyta", "Medvediev", "mnek1t", "28102004",1),
                new User(2,"Valeriia", "Istomina", "1stominaa", "28102004",2),
                new User(3,"Yurii", "Semenov", "semenov", "28102004",3),
            };
        }
        public override UserRole[] GetUserRoleData()
        {
            return new[]
            {
                new UserRole(1,"Admin"),
                new UserRole(2,"Registered"),
                new UserRole(3,"Guest"),
            };
        }
    }
}
