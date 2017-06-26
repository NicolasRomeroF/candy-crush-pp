using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCC
{
    
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICandyCrushService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICandyCrushService
    {

        [OperationContract]
        bool login(String user, String pass);

        [OperationContract]
        bool register(String user, String pass);

        [OperationContract]
        void setScore(int score, String user);

    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
   

}
