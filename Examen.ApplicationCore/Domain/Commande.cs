using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Commande
    {
        public string NumCmd { get; set; }
        public DateTime DateCmd { get; set; }
        public Boolean livree { get; set; }

        public Livreur livreur { get; set; }

        public virtual IList<LigneCommande> LigneCommandes { get; set; }
    }
}
