using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class LigneCommande
    {
        public int Quantite { get; set; }

        public string NumCmd { get; set; }
        public int IdPlat { get; set; }

        [ForeignKey("NumCmd")]
        public Commande Commande { get; set; }
        public Plat Plat { get; set; }
    }
}
