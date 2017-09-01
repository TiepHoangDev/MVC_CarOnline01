using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using CarOnline.Commom;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Plus.v1;
using Google.Apis.Util.Store;

namespace CarOnline.Controllers
{
    public class AuthCallbackController : Google.Apis.Auth.OAuth2.Mvc.Controllers.AuthCallbackController
    {
        // GET: AuthCallback
        protected override FlowMetadata FlowData
        {
            get { return new AppFlowMetadata(); }
        }

    }
    public class AppFlowMetadata : FlowMetadata
    {
        private static readonly IAuthorizationCodeFlow flow =
            new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = ConfigurationManager.AppSettings["GoogleAppId"],
                    ClientSecret = ConfigurationManager.AppSettings["GoogleAppSecret"]
                },
                Scopes = new[]
                {
                    PlusService.Scope.UserinfoEmail,
                    PlusService.Scope.UserinfoProfile
                },
                //DataStore = new FileDataStore(ConfigurationManager.AppSettings["GoogleStorage"], true)
                DataStore = new FileDataStore(HttpContext.Current.Server.MapPath("~/App_Data"), true)
            });

        public override string GetUserId(Controller controller)
        {
            // In this sample we use the session to store the user identifiers.
            // That's not the best practice, because you should have a logic to identify
            // a user. You might want to use "OpenID Connect".
            // You can read more about the protocol in the following link:
            // https://developers.google.com/accounts/docs/OAuth2Login.
            var user = controller.Session[Comomconstants.USER_SESSION];
            if (user == null)
            {
                user = Guid.NewGuid();
                controller.Session[Comomconstants.USER_SESSION] = user;
            }
            return user.ToString();

        }

        public override IAuthorizationCodeFlow Flow
        {
            get { return flow; }
        }
    }
	
}