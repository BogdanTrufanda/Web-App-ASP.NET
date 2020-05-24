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
    public class AfisareModel : PageModel
    {
        Interface1Client clt = new Interface1Client();

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public List<PaginawebDTO> PGO { get; set; }
        public List<PaginawebDTO> PGO2 { get; set; }
        public List<PaginawebDTO> PGO3 { get; set; }
        public AfisareModel()
        {
            PGO = new List<PaginawebDTO>();
            PGO2 = new List<PaginawebDTO>();
            PGO3 = new List<PaginawebDTO>();
        }

        public async Task OnGet()
        {
            PaginawebDTO pd = new PaginawebDTO();
            PaginawebDTO pd2 = new PaginawebDTO();
            PaginawebDTO pd3 = new PaginawebDTO();
            int val = 0, contor = 0;
            var valori = await clt.GetAllAsync();
            int ok = 1;
            foreach (var item in valori)
            {
                if (item.Contains(SearchString))
                {
                    contor++;
                    val++;
                }
                if (ok == 1)
                {
                    pd.justID = item;
                }
                else if (ok == 2)
                    pd.Name = item;
                else if (ok == 3)
                    pd.Path = item;
                else if (ok == 4)
                    pd.Size = item;
                else if (ok == 5)
                    pd.cDate = item;
                else if (ok == 6)
                    pd.mDate = item;
                else if (ok == 7)
                    pd.Extension = item;
                else if (ok == 8)
                {
                    pd.Resolution = item;
                    if (val > 0)
                    {
                        PGO.Add(pd);
                        if (pd.Name.Contains("."))
                            pd2.Pozaname = pd.Name;
                        else
                            pd2.Pozaname = pd.Name + pd.Resolution;
                        PGO2.Add(pd2);
                        val = 0;
                    }
                    ok = 0;
                    pd = new PaginawebDTO();
                    pd2 = new PaginawebDTO();
                }
                ok++;
            }
            string lastcontor = contor.ToString() + "    '" + SearchString + "'    " + " Found in Database!";
            pd3.Contor = lastcontor;
            Console.WriteLine(lastcontor);
            PGO3.Add(pd3);
        }
    }
}