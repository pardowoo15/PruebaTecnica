using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models.ViewModels
{
    public class VinculacionesViewModels
    {

    
        public int IdVinculacion { get; set; }
        [ForeignKey("IdEmpleado")]
        public int IdEmpleado { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
        [Required]
        public int IdCargo { get; set; }
        [Required]
        public DateTime FechaRetiro { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public List<VinculacionesViewModels> Items { get; set; }

    }
}