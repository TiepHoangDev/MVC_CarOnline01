﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.MODEL;

namespace IMIC.CONTROLLERS.BCL
{
    public class AccountBCL
    {
        private AccountDao ModelAccont;
        public AccountBCL()
        {
            ModelAccont = new AccountDao();
        }
        public List<AccountObject> GetAll()
        {
            return ModelAccont.GetAll();
        }

        public bool Insert(AccountObject ob)
        {
            return ModelAccont.Insert(ob);
        }
        public AccountObject GetByID(Guid AccountID)
        {
            return ModelAccont.GetByID(AccountID);
        }
        public bool Delete(Guid AccountID)
        {
            return ModelAccont.Delete(AccountID);
        }

        public bool Update(AccountObject ob)
        {
            return ModelAccont.Update(ob);
        }
        public int Login(string username, string password)
        {
            return ModelAccont.Login(username, password);
        }
        public AccountObject CheckLogin(string username, string password)
        {
            return ModelAccont.CheckLogin(username, password);
        }
        public AccountObject CheckUsername(string username)
        {
            return ModelAccont.CheckUsername(username);
        }

        public static AccountObject CheckFacebookId(string sFacebookId)
        {
            return AccountDao.CheckFacebookId(sFacebookId);
        }

        public static AccountObject CheckGoogleId(string sGoogleId)
        {
            return AccountDao.CheckGoogleId(sGoogleId);
        }
        public static bool CheckEmail(string sEmail)
        {
            return AccountDao.CheckMail(sEmail);
        }
    }
}
