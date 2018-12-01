using BasicTraining.App.Models.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BasicTraining.App
{
    class Program
    {

        static void Main(string[] args)
        {

        }


        static void UpdateCategory()
        {
            using (var dc = new TrainingContext())
            {
                var category = dc.Category
                    .Where(q => q.Id == 1)
                    .FirstOrDefault();

                category.Name = "Mouse";
                category.Slug = "mouse";

                dc.SaveChanges();
            }
        }

        static void ReadCategory()
        {
            using (var dc = new TrainingContext())
            {
                var categories = dc.Category
                    .Where(q => q.Name.Contains("Software"))
                    .ToList();

                foreach (var category in categories)
                {
                    Console.WriteLine(category.Name);
                }

                Console.ReadLine();
            }
        }

        static void CreateCategory()
        {
            using (var dc = new TrainingContext())
            {
                var category = new Category()
                {
                    Name = "Computer Hardware",
                    Slug = "computer-hardware",
                };

                dc.Category.Add(category);

                dc.SaveChanges();
            }
        }

    }
}
