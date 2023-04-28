using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models.ViewModels
{
    public class EmpleadosViewModel
    {
       
        public int IdEmpleado { get; set; }
        
        public string Nombres { get; set; }
    
        public string Apellidos { get; set; }
       
        public string Direccion { get; set; }
    
        [EmailAddress]
        public string Email { get; set; }
      
        public int IdGenero { get; set; }

        public int IdCiudad { get; set; }
        public List<EmpleadosViewModel> Items { get; set; }

    }
}