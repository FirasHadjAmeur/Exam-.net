using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Plat
    {
        public string Nom { get; set; }
        public int IdPlat { get; set; }
        
        public string TypePlat { get; set; }

        public string Photo { get; set; }

        public double Prix { get; set; }

        public List<Menu> menus { get; set; }

        public List<LigneCommande> LigneCommandes { get; set; }
    }
}
