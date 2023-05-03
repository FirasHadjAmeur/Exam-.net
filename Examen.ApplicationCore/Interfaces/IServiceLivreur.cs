using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceLivreur : IService<Livreur>
    {

        public IList<Livreur> GetAllLivreurs();

        public double GetBeneficeLivreur(Livreur livreur, DateTime date);
    }
}
