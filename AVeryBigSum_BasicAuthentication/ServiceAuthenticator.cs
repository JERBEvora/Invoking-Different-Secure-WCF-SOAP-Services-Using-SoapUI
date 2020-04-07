using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace AVeryBigSum
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))

                throw new SecurityTokenException("Username and password required");

            if (!(userName == ConfigurationManager.AppSettings["AVeryBigSum_User"] && password == ConfigurationManager.AppSettings["AVeryBigSum_Pass"]))

                throw new FaultException(string.Format("Wrong username ({0}) or password ", userName));

        }
    }
}