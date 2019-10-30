/*
 * 1.Регистрация и вход (смс код / email код)
 * 2.История покупок
 * 3.(картинка в файловой системе
 * 4.PayPal/Qiwi/etc
 * 5.
 * 6.пагинация
*/
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.DataAccess;
using Shop.DataAccess.Abstract;
using Shop.Domain;
using Shop.Services;
using System;
<<<<<<< Updated upstream
using System.Data.Common;
using System.Data.SqlClient;
=======
using System.Collections.Generic;
>>>>>>> Stashed changes
using System.IO;
using System.Linq;

namespace Shop.UI
{
  class Program
  {
    static void Main(string[] args)
    {
<<<<<<< Updated upstream
      var builder = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", false, true);

      IConfigurationRoot configurationRoot = builder.Build();
=======
      using (var context = new ShopContext("Server=A-305-07;Database=YetDatabase;Trusted_Connection=True;"))
      {
        //List<User> users = new List<User> {
        //  new User
        //  {
        //    Name = "Boris",
        //    Surname = "Deryabin",
        //    PhoneNumber = "+7(777)777-77-77",
        //    Email = "krutoi@gmail.com",
        //    Password = "7778888899991",
        //    VerificationCode = "111111"
        //  },
        //  new User
        //  {
        //                Name = "Nail",
        //    Surname = "Akchurin",
        //    PhoneNumber = "+7(777)777-77-77",
        //    Email = "krutoi@gmail.com",
        //    Password = "7778888899991",
        //    VerificationCode = "111111"
        //  },
        //  new User
        //  {
        //                Name = "Adil",
        //    Surname = "Nurym",
        //    PhoneNumber = "+7(777)777-77-77",
        //    Email = "krutoi@gmail.com",
        //    Password = "7778888899991",
        //    VerificationCode = "111111"
        //  },
        //  new User
        //  {
        //                Name = "Bekzat",
        //    Surname = "Toleutai",
        //    PhoneNumber = "+7(777)777-77-77",
        //    Email = "krutoi@gmail.com",
        //    Password = "7778888899991",
        //    VerificationCode = "111111"
        //  },
        //};
>>>>>>> Stashed changes

        //List<Item> items = new List<Item>
        //{
        //  new Item {
        //    Name = "Phone",
        //    ImagePath = "C:/data",
        //    Price = 1000,
        //    Description = "Cool",
        //    CategoryId = Guid.NewGuid()
        //  },
        //  new Item
        //  {
        //    Name = "Computer",
        //    ImagePath = "C:/data",
        //    Price = 10000,
        //    Description = "Cool",
        //    CategoryId = Guid.NewGuid()
        //  }
        //};

<<<<<<< Updated upstream
      DbProviderFactories.RegisterFactory(providerName, SqlClientFactory.Instance);
=======
        //List<Comment> comments = new List<Comment>
        //{
        //  new Comment
        //  {
        //    Value = "Cool",
        //    User = users[0],
        //    Item = items[0]
        //  },
        //  new Comment
        //  {
        //    Value = "Very Cool",
        //    User = users[0],
        //    Item = items[0]
        //  },
        //  new Comment
        //  {
        //    Value = "Bad",
        //    User = users[0],
        //    Item = items[0]
        //  },
        //  new Comment
        //  {
        //    Value = "Can play",
        //    User = users[0],
        //    Item = items[0]
        //  }
        //};
>>>>>>> Stashed changes

        //context.Add(items[0]);
        //context.Add(items[1]);
        //context.Add(users[0]);
        //context.Add(users[1]);
        //context.Add(users[2]);
        //context.Add(users[3]);
        //context.Add(comments[0]);
        //context.Add(comments[1]);
        //context.Add(comments[2]);
        //context.Add(comments[3]);

<<<<<<< Updated upstream
      string connectionString = configurationRoot.GetConnectionString("DebugConnectionString");

      ICategoryRepository repository = new CategoryRepository(
        connectionString,
        providerName
        );
      repository.Add(category);

      var result = repository.GetAll();
=======
        //context.SaveChanges();

        var result = context.ItemsUsers
          .Include(x => x.User)
          .Include(x => x.Item)
          .ToList();
      }
>>>>>>> Stashed changes
    }
  }
}
