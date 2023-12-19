using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExamenUF2.Model
{
    public partial class contacte
    {
        public override string ToString()
        {
            return this.cognoms + ", " + this.nom;
        }
    }
}
