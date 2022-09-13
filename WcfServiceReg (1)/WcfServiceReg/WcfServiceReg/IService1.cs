using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceReg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.




    // Use a data contract as illustrated in the sample below to add composite types to service operations.

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string UserLogin(vlogin login);



        [OperationContract]

        string RegisterInsert(UserRegister1 userreg);

    }

    [DataContract]
    public class vlogin
    {
        public string vusername;
        public string vpassword;

        [DataMember]
        public string UserName
        {
            get { return vusername; }
            set { vusername = value; }
        }
        [DataMember]
        public string Password
        {
            get
            { return vpassword; }
            set { vpassword = value; }
        }
    }




    [DataContract]

    public class UserRegister1
    {
        public string vusername;
        public string vpassword;

        public static object Username { get; internal set; }
        public static object password { get; internal set; }

        //public static string Username { get; internal set; }
        //public static string Password { get; internal set; }

        [DataMember]

        public string UserName
        {
            get { return vusername; }
            set { vusername = value; }
        }
        [DataMember]
        public string Password
        {
            get
            { return vpassword; }
            set { vpassword = value; }
        }
    }
}










