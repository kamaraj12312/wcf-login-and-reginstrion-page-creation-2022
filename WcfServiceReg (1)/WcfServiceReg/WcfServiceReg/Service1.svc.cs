using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;



namespace WcfServiceReg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
      



        public string UserLogin(vlogin login)
        {
            LogIn vlogin = new LogIn();
            vlogin.Username = login.UserName;
            vlogin.Password = login.Password;
            return vlogin.UserLogin();


        }

        public string RegisterInsert(UserRegister1 userreg)
        {
            Register UserRegister1 = new Register();
            UserRegister1.Username = userreg.UserName;
            UserRegister1.Password = userreg.Password;

            return UserRegister1.RegisterInsert();

        }

       
    }
}

