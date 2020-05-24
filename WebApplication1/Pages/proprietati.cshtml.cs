using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class proprietatiModel : PageModel
    {
        Interface1Client clt = new Interface1Client();

        public List<PaginawebDTO> PGO { get; set; }
        public proprietatiModel()
        {
            PGO = new List<PaginawebDTO>();
        }

        public async Task OnGet()
        {
            PaginawebDTO pd = new PaginawebDTO();
            List<string> prop = new List<string>();
            var valori = await clt.GetColumnNamesAsync();
            foreach (var item in valori)
            { 
                prop.Add(item);
            }
            prop.Sort();
            pd.Prop = prop;
            PGO.Add(pd);


        }
    }
}