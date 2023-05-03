using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Commande
    {

        public string NumCmd { get; set; }

        [Display(Name = "Date Commande")]
        public DateTime DateCmd { get; set; }
        public bool livree { get; set; }

        public Livreur livreur { get; set; }

        public virtual IList<LigneCommande> LigneCommandes { get; set; }
    }
}
