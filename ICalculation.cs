using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_workshop
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract(Namespace = "http://eXia_A4_WCF1")]
    public interface ICalculation
    {

        [OperationContract]
        int m_add(int n, int m);

        [OperationContract]
        int m_sous(int n, int m);

        /*[OperationContract]
        ReadOnlyCollection<IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password);*/
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class MSG
    {
        bool op_statut { get; set; }

        [DataMember]
        string op_name { get; set; }

        string op_infos { get; set; }

        string app_name { get; set; }

        string app_version { get; set; }

        [DataMember]
        string app_token { get; set; }

        string user_token { get; set; }

        string user_login { get; set; }

        string user_password { get; set; }

        Object[] data_table { get; set; }
    }
}
