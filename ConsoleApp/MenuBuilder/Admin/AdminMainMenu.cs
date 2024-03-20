using ConsoleApp.Controllers;
using ConsoleApp.Services;
using ConsoleApp1;
using StoreDAL.Data;

namespace ConsoleMenu.Builder;

public class AdminMainMenu:AbstractMenuCreator
{
    public override (ConsoleKey id, string caption, Action action)[] GetMenuItems(StoreDbContext context)
    {
        (ConsoleKey id, string caption, Action action)[] array = {
            (ConsoleKey.F1,"Logout", UserMenuController.Logout)  //()=>{Console.WriteLine("Logout Action");}
            ,(ConsoleKey.F2,"Show product list", ()=>{ProductController.ShowAllProducts();})
            ,(ConsoleKey.F3,"Add product", ()=>{ProductController.AddProduct();})
            ,(ConsoleKey.F4,"Show order list", ()=>{ShopController.ShowAllOrders();})
            ,(ConsoleKey.F5,"Cancel order", ()=>{ShopController.DeleteOrder();})
            ,(ConsoleKey.F6,"Change order status", ()=>{ShopController.UpdateOrderDetails();})
            ,(ConsoleKey.F7,"User roles", UserController.ShowAllUserRoles)
            ,(ConsoleKey.F8,"Order states", ShopController.ShowAllOrderStates)
        };
        return array;
    }
}