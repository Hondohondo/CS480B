using hw3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw3.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new hw3Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<hw3Context>>()))
            {
                if (context.Author.Any() || context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        Quotation = "Whatever will be will be, the future is not ours to see",
                       

                    },
                    
                    new Quote
                    {
                        Quotation = "Que Sera Sera",
                       

                    }

                  
                );
                context.SaveChanges();

                context.Author.AddRange(
                    new Author
                    {
                        AuthorName = "Doris Day",
                        

                    },

                    new Author
                    {
                        AuthorName = "Dan Alves",

                    }

                );
                context.SaveChanges();


            }
        }
}
