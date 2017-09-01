using System;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using CarOnline.Commom;
using Facebook;
using Google.Apis.Auth.OAuth2.Mvc;
using Google.Apis.Plus.v1;
using Google.Apis.Services;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.CONTROLLERS.BCL;

namespace CarOnline.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginClient
        public ActionResult LoginClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginClient(Login_Object loginObject)
        {
            if (ModelState.IsValid)
            {
                var result = new AccountBCL().Login(loginObject.Username, loginObject.Password);

                switch (result)
                {
                    case 1:
                        {
                            var accountLogin = new AccountBCL().CheckLogin(loginObject.Username, loginObject.Password);
                            // session
                            Session.Add(Comomconstants.USER_SESSION, accountLogin);
                            // cookie
                            FormsAuthentication.SetAuthCookie(loginObject.Username, loginObject.RememberMe);
                            return RedirectToAction("Index", "Home");
                        }

                    case 0:
                        {
                            ModelState.AddModelError("", "Tài khoản không tồn tại");

                            break;
                        }
                    case -2:
                        {
                            ModelState.AddModelError("", "Mật khẩu không chính xác");
                            break;
                        }


                    case -1:
                        {
                            ModelState.AddModelError("", "Tài khoản này đang bị khóa");
                            break;
                        }


                    case 2:
                        {
                            ModelState.AddModelError("", "Tài khoản này đã bị xóa");
                            break;
                        }

                }
            }
            return View(loginObject);
        }

        #region Login with Facebook
        private Uri RedirectUri
        {
            get
            {
                if (Request.Url == null) return null;
                var uriBuilder = new UriBuilder(Request.Url) { Query = null, Fragment = null };
                var action = Url.Action("FacebookCallback");
                if (action != null) uriBuilder.Path = action;
                return uriBuilder.Uri;
            }


        }

        public ActionResult FacebookCallback(string code)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = ConfigurationManager.AppSettings["FacebookAppId"],
                client_secret = ConfigurationManager.AppSettings["FacebookAppSecret"],
                redirect_uri = RedirectUri.AbsoluteUri,
                code
            });

            var accessToken = result.access_token;
            if (!string.IsNullOrEmpty(accessToken))
            {
                fb.AccessToken = accessToken;
                // Get the user's information, like email, first name, middle name etc
                dynamic me = fb.Get("me?fields=id,name,gender,picture,email,birthday,locale");

                // Kiểm tra xem tk đã có trong csdl chưa qua facebook id
                var objAccountRsChecked = AccountBCL.CheckFacebookId(me.id);
                if (objAccountRsChecked != null)
                {
                    // Đã có trong csdl rồi
                    // Tạo session đăng nhập thành công
                    Session.Add(Comomconstants.USER_SESSION, objAccountRsChecked);

                    // Tải lại trang
                    return RedirectToAction("Index", "Home");
                }
                // Nếu chưa có tk, insert vào csdl đăng ký. Sau đó tạo session đăng nhập thành công
                // Đóng gói đối tượng 
                var birthDay = me.birthday;
                var objAccount = new AccountObject()
                {
                    Email = me.email,
                    FullName = me.name,
                    ID_Facebook = me.id,
                    Avatar = me.picture.data.url
                };
                if (!string.IsNullOrEmpty(birthDay))
                {
                    objAccount.BirthDay = DateTime.ParseExact(birthDay, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                }


                // Nếu ko lấy đc mail thì dãn đến trang cho phép nhập mail
                if (string.IsNullOrEmpty(objAccount.Email))
                {
                    ViewBag.ErrorEmail = false; // Tạm thời chưa có lỗi ở email
                    return View("ConfirmEmail", objAccount);
                }
                // Insert tk xuống csdl
                objAccount.AccountID = Guid.NewGuid();
                // objAccount.RoleId = 100; // tk thường

                new AccountBCL().Insert(objAccount);

                // Tạo session
                Session.Add(Comomconstants.USER_SESSION, objAccount);

                // Tải lại trang
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        // Từ view gọi vào hàm này để xử lý login fb
        public ActionResult LoginFacebook()
        {
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = ConfigurationManager.AppSettings["FacebookAppId"],
                client_secret = ConfigurationManager.AppSettings["FacebookAppSecret"],
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "public_profile,email,user_birthday",
            });

            return Redirect(loginUrl.AbsoluteUri);
        }
        #endregion

        public ActionResult ConfirmEmail(AccountObject objAccount)
        {
            //objAccount.Gender = Request["Gender"].Equals("male"); // Lấy giới tính string => bool

            // Check email empty string + không trùng trong db
            if (string.IsNullOrEmpty(objAccount.Email) && AccountBCL.CheckEmail(objAccount.Email))
            {
                // Nếu email trống hoặc đã tồn tại, tải lại trang và yêu cầu kiểm tra lại
                ViewBag.ErrorEmail = true; // Mình thích thì mình báo lỗi thôi
                return View(objAccount);
            }

            // Email đã hợp lệ
            // Cho phép thêm tài khoản vào csdl
            objAccount.AccountID = Guid.NewGuid();
            //objAccount.RoleId = 3; // tk thường
            //objAccount.ModifiedTime = DateTime.Now;
            new AccountBCL().Insert(objAccount);

            // Tạo session
            Session.Add(Comomconstants.USER_SESSION, objAccount);

            // Tải lại trang
            return RedirectToAction("Index", "Home");
        }

        #region Login with Google

        public async Task<ActionResult> LoginGoogle(CancellationToken cancellationToken)
        {
            var result = await new AuthorizationCodeMvcApp(this, new AppFlowMetadata()).
                AuthorizeAsync(cancellationToken);

            if (result.Credential == null)
                return new RedirectResult(result.RedirectUri);

            var plusService = new PlusService(new BaseClientService.Initializer
            {
                HttpClientInitializer = result.Credential,
                ApplicationName = "MvcLogin App"
            });

            // Lấy thông tin cơ bản của user
            var me = plusService.People.Get("me").Execute();

            if (me != null)
            {
                // Kiểm tra xem tk đã có trong csdl chưa qua google id
                var objAccountRsChecked = AccountBCL.CheckGoogleId(me.Id);
                if (objAccountRsChecked != null)
                {
                    // Đã có trong csdl rồi
                    // Tạo session đăng nhập thành công
                    Session.Add(Comomconstants.USER_SESSION, objAccountRsChecked);

                    // Tải lại trang
                    return RedirectToAction("Index", "Home");
                }
                // Nếu chưa có tk, insert vào csdl đăng ký. Sau đó tạo session đăng nhập thành công
                // Đóng gói đối tượng 
                var objAccount = new AccountObject()
                {
                    Email = me.Emails.ElementAt(0).Value,
                    FullName = me.Name.GivenName + " " + me.Name.FamilyName,
                    ID_Gmail = me.Id,
                    Avatar = me.Image.Url
                };
                //string DisplayName = me.DisplayName;
                //string Provider = IdentityProvider.Google;

                // Insert tk xuống csdl
                objAccount.AccountID = Guid.NewGuid();
                //objAccount.RoleId = 3; // tk thường
                //objAccount.ModifiedTime = DateTime.Now;
                new AccountBCL().Insert(objAccount);

                // Tạo session
                Session.Add(Comomconstants.USER_SESSION, objAccount);

                // Tải lại trang
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        #endregion

    }
}