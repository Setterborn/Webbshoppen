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
            ProductManager.SortList(index);
        }
    }
}
