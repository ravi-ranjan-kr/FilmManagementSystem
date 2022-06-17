using FilmManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace FilmManagementSystem.Repositories
{
    public class CategoryRepository
    {
        private readonly FilmManagementSystemContext context;
        public CategoryRepository()
        {
            context = new FilmManagementSystemContext();
        }
        public void AddCategory(Category category) // add category details
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }
        public List<Category> GetCategory() // getting all category data
        {
            return context.Categories.ToList();
        }
        public Category GetCategorybyName(string categoryname) //getting category details by categoryname
        {
            Category category = context.Categories.SingleOrDefault(s => s.CategoryName == categoryname);
            return category;
        }
        public void EditCategory(Category category)// updating category data
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
        public void DeleteCategory(string id) // deleting data using id
        {
            Category category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
        }

    }
}
