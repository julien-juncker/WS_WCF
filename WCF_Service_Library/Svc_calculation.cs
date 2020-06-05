using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service_Library
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Svc_calculation : ICalculation
    {
        public int m_add(int n, int m)
        {
            return n + m;
        }

        public int m_sous(int n, int m)
        {
            return n - m;
        }
    }
}
