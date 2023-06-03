using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Mocks
{
    public class MockCategory : ICategory
    {

        private List<Category> categorys;
        public MockCategory()
        {
            categorys = new List<Category>()
            {
                new Category { Id = 1, Name = "Roza"},
                new Category { Id = 2, Name = "Tulpan"},
                new Category { Id = 2, Name = "Trojan"},
            };
        }
        public void AddCategorys(Category category)
        {
            category.Id = categorys.Count;
            categorys.Add(category);
        }

        public void DellCategorys(int id)
        {
            var findInd = categorys.FindIndex(i => i.Id == id);
            if (findInd >= 0) { categorys.RemoveAt(findInd); };
        }

        public List<Category> GetCategorys()
        {
            return categorys;
        }
    }
}
