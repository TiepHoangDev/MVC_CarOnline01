﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class AccountDao
    {
        public List<AccountObject> GetAll()
        {

            var list = new CarOnlineEntities().WEB_CARONLINE_SP_Account_GetAll().ToList();
            List<AccountObject> lst = new List<AccountObject>();
            foreach (var item in list)
            {
                AccountObject obj = new AccountObject();

                obj.AccountID = item.AccountID;
                obj.ID_Facebook = item.ID_Facebook;
                obj.ID_Gmail = item.ID_Gmail;
                obj.UserName = item.UserName;
                obj.Password = item.Password;
                obj.Avatar = item.Avatar;
                obj.FullName = item.FullName;
                obj.RoleID = item.RoleID.GetValueOrDefault();
                obj.NumberOfLikeProfile = item.NumberOfLikeProfile.GetValueOrDefault();
                obj.NumberOfPost = item.NumberOfPost.GetValueOrDefault();
                obj.NumberOfFlow = item.NumberOfFlow.GetValueOrDefault();
                obj.NumberOfComment = item.NumberOfComment.GetValueOrDefault();
                obj.Mobile = item.Mobile;
                obj.Active = (bool)item.Active;
                obj.BirthDay = item.BirthDay.GetValueOrDefault();
                obj.JoinDay = item.JoinDay.GetValueOrDefault();
                obj.Email = item.Email;
                obj.Address = item.Address;
                obj.IsDeleted = item.IsDeleted.GetValueOrDefault(false);
                obj.RoleObj = new RoleDao().GetById(obj.RoleID);
                lst.Add(obj);

            }
            return lst;
        }
        public AccountObject GetByID(Guid AccountID)
        {

            var list = new CarOnlineEntities().WEB_CARONLINE_SP_Account_GetById(AccountID);

            foreach (var item in list)
            {
                AccountObject obj = new AccountObject();

                obj.AccountID = item.AccountID;
                obj.ID_Facebook = item.ID_Facebook;
                obj.ID_Gmail = item.ID_Gmail;
                obj.UserName = item.UserName;
                obj.Password = item.Password;
                obj.Avatar = item.Avatar;
                obj.FullName = item.FullName;
                obj.NumberOfLikeProfile = item.NumberOfLikeProfile.GetValueOrDefault();
                obj.NumberOfPost = item.NumberOfPost.GetValueOrDefault();
                obj.NumberOfFlow = item.NumberOfFlow.GetValueOrDefault();
                obj.NumberOfComment = item.NumberOfComment.GetValueOrDefault();
                obj.Mobile = item.Mobile;
                obj.Active = (bool)item.Active;
                obj.BirthDay = item.BirthDay.GetValueOrDefault();
                obj.JoinDay = item.JoinDay.GetValueOrDefault();
                obj.Email = item.Email;
                obj.Address = item.Address;
                obj.IsDeleted = item.IsDeleted.GetValueOrDefault();
                return obj;
            }
            return null;
        }
        public AccountObject CheckUsername(string username)
        {
            var list = new CarOnlineEntities().WEB_CARONLINE_SP_Account_CheckUserName(username);

            foreach (var item in list)
            {
                AccountObject obj = new AccountObject();

                obj.AccountID = item.AccountID;
                obj.ID_Facebook = item.ID_Facebook;
                obj.ID_Gmail = item.ID_Gmail;
                obj.UserName = item.UserName;
                obj.Password = item.Password;
                obj.Avatar = item.Avatar;
                obj.FullName = item.FullName;
                obj.NumberOfLikeProfile = item.NumberOfLikeProfile.GetValueOrDefault();
                obj.NumberOfPost = item.NumberOfPost.GetValueOrDefault();
                obj.NumberOfFlow = item.NumberOfFlow.GetValueOrDefault();
                obj.NumberOfComment = item.NumberOfComment.GetValueOrDefault();
                obj.Mobile = item.Mobile;
                obj.Active = (bool)item.Active;
                obj.BirthDay = item.BirthDay.GetValueOrDefault();
                obj.JoinDay = item.JoinDay.GetValueOrDefault();
                obj.Email = item.Email;
                obj.Address = item.Address;
                obj.IsDeleted = item.IsDeleted.GetValueOrDefault();
                return obj;
            }
            return null;
        }
        public AccountObject CheckLogin(string username, string password)
        {
            var list = new CarOnlineEntities().WEB_CARONLINE_SP_Account_CheckLogin(username, password);

            foreach (var item in list)
            {
                AccountObject obj = new AccountObject();

                obj.AccountID = item.AccountID;
                obj.ID_Facebook = item.ID_Facebook;
                obj.ID_Gmail = item.ID_Gmail;
                obj.UserName = item.UserName;
                obj.Password = item.Password;
                obj.Avatar = item.Avatar;
                obj.FullName = item.FullName;
                obj.NumberOfLikeProfile = item.NumberOfLikeProfile.GetValueOrDefault();
                obj.NumberOfPost = item.NumberOfPost.GetValueOrDefault();
                obj.NumberOfFlow = item.NumberOfFlow.GetValueOrDefault();
                obj.NumberOfComment = item.NumberOfComment.GetValueOrDefault();
                obj.Mobile = item.Mobile;
                obj.Active = (bool)item.Active;
                obj.BirthDay = item.BirthDay.GetValueOrDefault();
                obj.JoinDay = item.JoinDay.GetValueOrDefault();
                obj.Email = item.Email;
                obj.Address = item.Address;
                obj.IsDeleted = item.IsDeleted.GetValueOrDefault();
                return obj;
            }
            return null;
        }
        public int Login(string username, string password)
        {
            var result = new AccountDao().CheckUsername(username);
            if (result == null)
            {
                return 0;
            }
            else if (result.Active == false)
            {
                return -1;
            }
            else if (result.IsDeleted == true)
            {
                return 2;
            }
            else if (result.Password == password)
                return 1;
            return -2;
        }
        public bool Insert(AccountObject ob)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_Account_Insert(ob.AccountID, ob.RoleID, ob.ID_Facebook, ob.ID_Gmail,
                ob.UserName, ob.Password, ob.Avatar, ob.FullName, ob.NumberOfLikeProfile, ob.NumberOfPost, ob.NumberOfFlow,
                ob.NumberOfComment, ob.Mobile, ob.Active, ob.BirthDay, ob.JoinDay, ob.Email, ob.Address, ob.IsDeleted) > 0;
        }


        public bool Delete(Guid AccountID)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_Account_Delete(AccountID) > 0;
        }


        public bool Update(AccountObject ob)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_Account_Update(ob.AccountID, ob.RoleID, ob.ID_Facebook, ob.ID_Gmail,
                ob.UserName, ob.Password, ob.Avatar, ob.FullName, ob.NumberOfLikeProfile, ob.NumberOfPost, ob.NumberOfFlow,
                ob.NumberOfComment, ob.Mobile, ob.Active, ob.BirthDay, ob.JoinDay, ob.Email, ob.Address, ob.IsDeleted) > 0;
        }
    }
}