using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshoppen.Models;
using Webbshoppen.Data;

namespace Webbshoppen.Pages
{
    public class ViewSortedListModel : PageModel
    {
        public List<Product> SortedList { get; set; }

        public void OnGet(int index)
        {
            switch (index)
            {
                case 1:
                    SortedList = ProductManager.ProductList;
                    break;
                case 2:
                    SortedList = ProductManager.ProductList.Where(prod => prod.Gender is Gender.Male).ToList(); 
                    break;
                case 3:
                    SortedList = ProductManager.ProductList.Where(prod => prod.Gender is Gender.Female).ToList();
                    break;
                case 4:
                    SortedList = ProductManager.ProductList.Where(prod => prod.Gender is Gender.Female).ToList();
                    break;
                case 5:

                    break;



            }
        }
    }
}
