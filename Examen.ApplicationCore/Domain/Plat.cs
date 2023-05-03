using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Plat
    {
       
        [StringLength(50, ErrorMessage = "Le nom du plat ne doit pas dépasser 50 caractères")]
        public string Nom { get; set; }
        public int IdPlat { get; set; }
        
        public string TypePlat { get; set; }

        public string Photo { get; set; }

        [Range(40, double.MaxValue, ErrorMessage = "Le prix doit être supérieur à 40")]
        public double Prix { get; set; }

        public virtual List<Menu> menus { get; set; }

        public virtual List<LigneCommande> LigneCommandes { get; set; }
    }
}
