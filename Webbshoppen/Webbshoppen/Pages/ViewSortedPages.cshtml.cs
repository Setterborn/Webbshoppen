using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webbshoppen.Data;

namespace Webbshoppen.Pages
{
    public class ViewSortedPagesModel : PageModel
    {
        public void OnGet(int index)
        {
            switch (index)
            {
                case 1:
                    ProductManager.SortedList = ProductManager.ProductList;
                    break;
                case 2:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p.Gender is Models.Gender.Male).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 3:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p.Gender is Models.Gender.Female).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 4:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Jackets).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 5:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Shoes).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 6:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Shirts).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 7:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Pants).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 8:
                    ProductManager.SortedList = ProductManager.ProductList.Where(p => p is Models.Underwear).ToList();
                    ProductManager.UpdateProductId(ProductManager.SortedList);
                    break;
                case 9:

                    break;

            }
        }
    }
}
