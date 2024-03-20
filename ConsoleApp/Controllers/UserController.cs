﻿using ConsoleApp1;
using StoreDAL.Data;
using StoreBLL.Models;
using StoreBLL.Services;
using ConsoleApp.Controllers;
using ConsoleApp.Handlers.ContextMenu;
using ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMenu;

namespace ConsoleApp.Services
{
    public static class UserController
    {
        private static StoreDbContext context = UserMenuController.Context;
        public static void AddUser()
        {
            var service = new UserService(context);
            service.Add(InputHelper.ReadRegistration());
        }
        public static void UpdateUser()
        {
            throw new NotImplementedException();
        }

        public static void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public static void ShowUser()//???
        {
            throw new NotImplementedException();
        }
        public static void ShowAllUsers()
        {
            throw new NotImplementedException();
        }

        public static void AddUserRole()
        {
            throw new NotImplementedException();
        }
        public static void UpdateUserRole()
        {
            throw new NotImplementedException();
        }

        public static void DeleteUserRole()
        {
            throw new NotImplementedException();
        }


        public static void ShowAllUserRoles()
        {
            var service = new UserRoleService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service,InputHelper.ReadUserRoleModel),service.GetAll);
            menu.Run();
            //throw new NotImplementedException();
        }

        public static void AddProductTitle()
        {
            throw new NotImplementedException();
        }
        public static void UpdateProductTitle()
        {
            throw new NotImplementedException();
        }

        public static void DeleteProductTitle()
        {
            throw new NotImplementedException();
        }

        public static void ShowAllProductTitles()
        {
            throw new NotImplementedException();
        }

        public static void AddManufacturer()
        {
            throw new NotImplementedException();
        }
        public static void UpdateManufacturer()
        {
            throw new NotImplementedException();
        }

        public static void DeleteManufacturer()
        {
            throw new NotImplementedException();
        }

        public static void ShowAllManufacturers()
        {
            throw new NotImplementedException();
        }
    }
}
