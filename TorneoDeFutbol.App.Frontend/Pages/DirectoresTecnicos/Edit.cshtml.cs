using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.DirectoresTecnicos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico directorTecnico{get; set;}
        public EditModel(IRepositorioDirectorTecnico repoDirectorTecnico){
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public IActionResult OnGet(int id)
        {
            directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            if(directorTecnico == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }

        }
        public IActionResult OnPost(DirectorTecnico directorTecnico){
            _repoDirectorTecnico.UpdateDirectorTecnico(directorTecnico);
            return RedirectToPage("Index");
        }
    }
}
