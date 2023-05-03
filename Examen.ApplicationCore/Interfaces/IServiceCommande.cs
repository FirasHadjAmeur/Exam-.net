using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceCommande : IService<Commande>
    {
      public double GetPrixCommande(Commande commande);
    }
}
