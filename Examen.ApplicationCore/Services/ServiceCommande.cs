using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceCommande : Service<Commande>, IServiceCommande
    {
        public ServiceCommande(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double GetPrixCommande(Commande commande)
        {
            double prix = 0;
            foreach (var item in commande.LigneCommandes)
            {
                prix += item.Plat.Prix  * item.Quantite;
            }
            return prix;
        }
    }
}
