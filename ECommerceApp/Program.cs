using System;
using System.Linq;
using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp
{
    internal class Program
    {
        // Shared DbContext
        static AppDbContext context = new AppDbContext();

        // Login state
        static int loggedInUserId = 0;


        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine("1. Register New User");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Add New Category");
                Console.WriteLine("4. Add New Product");
                Console.WriteLine("5. View All Products");
                Console.WriteLine("6. Place an Order");
                Console.WriteLine("7. View My Orders");
                Console.WriteLine("8. View Order Details");
                Console.WriteLine("9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        RegisterUser();
                        break;

                    case 2:
                        Login();
                        break;

                    case 3:
                        AddCategory();
                        break;

                    case 4:
                        AddProduct();
                        break;

                    case 5:
                        ViewAllProducts();
                        break;

                    case 6:
                        PlaceOrder();
                        break;

                    case 7:
                        ViewMyOrders();
                        break;

                    case 8:
                        ViewOrderDetails();
                        break;

                    case 9:
                        AddReview();
                        break;

                    case 10:
                        ViewReviewsForProduct();
                        break;

                    case 11:
                        Logout();
                        break;

                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }



        // ===================== FUNCTIONS =====================


        static void RegisterUser()
        {
            User user = new User();

            Console.WriteLine("Enter your username:");
            user.UserName = Console.ReadLine();

            Console.WriteLine("Enter your email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            user.Password = Console.ReadLine();

            context.Users.Add(user);
            context.SaveChanges();

            Console.WriteLine("User registered successfully!");
        }


        static void Login()
        { 
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            
            User user = context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);
            
            if (user != null)
            {
                loggedInUserId = user.UserId;
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
            }

        }


        static void AddCategory()
        {
            static void AddCategory()
            {
                Category category = new Category();

                Console.WriteLine("Enter category name:");
                category.CategoryName = Console.ReadLine();

                context.Categories.Add(category);
                context.SaveChanges();

                Console.WriteLine("Category added successfully!");
            }
        }


        static void AddProduct()
        {
            Product product = new Product();

            Console.WriteLine("Enter product name:");
            product.ProductName = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            product.ProductPrice = decimal.Parse(Console.ReadLine());
          
            // Display categories
            var categories = context.Categories.ToList();

            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryId + " - " + category.CategoryName);            }


            Console.WriteLine("Choose category id:");
            int categoryId = int.Parse(Console.ReadLine());
            
            product.CategoryId = categoryId;


            context.Products.Add(product);
            context.SaveChanges();
            Console.WriteLine("Product added successfully!");
            
        }


        static void ViewAllProducts()
        { 
            var products = context.Products
                .Include(p => p.Category)
                .ToList();
            foreach (var product in products)
            {
                Console.WriteLine(
                    product.ProductName + " - " +
                    product.ProductPrice + " - " +
                    product.Category.CategoryName
                );
            
                }
        }


        static void PlaceOrder()
        {

        }


        static void ViewMyOrders()
        {

        }


        static void ViewOrderDetails()
        {

        }


        static void AddReview()
        {

        }


        static void ViewReviewsForProduct()
        {

        }


        static void Logout()
        {

        }

    }
}