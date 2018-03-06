using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Sens___Devis.classMetier
{
    class classHotesse : classPersonnel
    {
        private List<classPersonnalisation> laPersonnalisation;

        public classHotesse(String unNomHotesse, classTarif unTarif, List<classPersonnalisation> unePersonnalisation) : base(unNomHotesse, unTarif)
        {
                    
        }
    }
}
