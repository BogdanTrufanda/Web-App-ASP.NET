using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class PaginawebModel : PageModel
    {
        Interface1Client clt = new Interface1Client();

        // public IList<PaginawebModel> Poza { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public List<PaginawebDTO> PGO { get; set; }
        public PaginawebModel()
        {
            PGO = new List<PaginawebDTO>();
        }
        public async Task OnGet()
        {
            if (string.IsNullOrEmpty(SearchString))
            {
                var valori = await clt.GetAllAsync();
                int ok = 1;
                PaginawebDTO pd = new PaginawebDTO();
                foreach (var item in valori)
                {
                    //Console.WriteLine(item);
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
                        PGO.Add(pd);
                        ok = 0;
                        pd = new PaginawebDTO();
                    }
                    ok++;
                }
            }
            }
        }
 }

