using Microsoft.Xrm.Sdk;
using ExcelToMSCRMImport.Library;


namespace Namespace.Library
{
    /// <summary>
    /// MapHelper yardımı ile ExcelObject'i Dynamics MS CRM Account Varlığına (Objesine) çevirilecektir.
    /// </summary>
    /// 
    /// 

    public class clientAccount
    {



    }

    public class MapHelper
    {
        public Entity ObjectConvertoEntity(ExcelObject excelobject)
        {
            clientAccount abc = new clientAccount();

            Entity entity = new Entity();
            //entity["accountname"] = "";
            //entity["emailaddress1"] = "";
            //entity["emailaddress2"] = "";
            //entity["telephone1"] = "";
            //entity["telephone2"] = "";

            entity.Attributes.Add("accountname", "");
            entity.Attributes.Add("emailaddress1", "");
            entity.Attributes.Add("emailaddress2", "");
            entity.Attributes.Add("telephone1", "");
            entity.Attributes.Add("telephone2", "");

            //Varlık alanları aşağıdadır.
            //Alanların varlık üzerine maplemesi gereklidir.
            //Objenin nasıl doldurulacağını araştıraak bulmanızı bekliyoruz.
            //Aşağıdaki 5 alan string tipindedir.
            //accountname,emailaddress1,emailaddress2,telephone1,telephone2

            return entity;
        }
    }
}
