
using System;
using System.Collections.Generic;
using System.Linq;
using IMIC.BUSINESSOBJECTS.EntityObject;
using IMIC.ENTITYMODELS.DATA;

namespace IMIC.ENTITYMODELS.MODEL
{
    public class PostDao
    {

        public List<PostObject> GetAll()
        {
            var list = new CarOnlineEntities().WEB_CARONLINE_SP_Post_GetAll();
            List<PostObject> lst = new List<PostObject>();
            foreach (var item in list)
            {
                var obj = new PostObject();

                obj.AccountID = item.AccountID;
                obj.AdministratorID = item.AdministratorID;
                obj.Approved = item.Approved == true;
                obj.ApprovedDay = item.ApprovedDay;
                obj.CarGearId = item.CarGearId;
                obj.CarPrice = item.CarPrice;
                obj.CarStatusID = item.CarStatusID;
                obj.ExteriorColorID = item.ExteriorColorID;
                obj.FuelID = item.FuelID;
                obj.FurnitureColorID = item.FurnitureColorID;
                obj.IsDeleted = item.IsDeleted == true;
                obj.KmWent = item.KmWent;
                obj.LastContactDay = item.LastContactDay;
                obj.MadeInId = item.MadeInId;
                obj.Note = item.Note;
                obj.NumberOfDoorId = item.NumberOfDoorId;
                obj.NumberOfSeatId = item.NumberOfSeatId;
                obj.PostContent = item.PostContent;
                obj.PostDay = item.PostDay;
                obj.PostId = item.PostId;
                obj.PostTitle = item.PostTitle;
                obj.ProducedYear = item.ProducedYear;
                obj.SaleStatusCarID = item.SaleStatusCarID;
                obj.TypeOfCarID = item.TypeOfCarID;
                obj.UpdatePostDay = item.UpdatePostDay;
                obj.WheelDriveId = item.WheelDriveId;
                obj.AccountPostJoin = new AccountObject()
                {

                    AccountID = (System.Guid)item.AccountID,
                    Active = item.Active_AccountPostJoin == true,
                    Address = item.Address_AccountPostJoin,
                    Avatar = item.Avatar_AccountPostJoin,
                    BirthDay = (DateTime)item.BirthDay_AccountPostJoin,
                    Email = item.Email_AccountPostJoin,
                    FullName = item.FullName_AccountPostJoin,
                    ID_Facebook = item.ID_Facebook_AccountPostJoin,
                    ID_Gmail = item.ID_Gmail_AccountPostJoin,
                    IsDeleted = item.IsDeleted_AccountPostJoin == true,
                    JoinDay = item.JoinDay_AccountPostJoin,
                    Mobile = item.Mobile_AccountPostJoin,
                    NumberOfComment = item.NumberOfComment_AccountPostJoin,
                    NumberOfFlow = item.NumberOfFlow_AccountPostJoin,
                    NumberOfLikeProfile = item.NumberOfLikeProfile_AccountPostJoin,
                    NumberOfPost = item.NumberOfPost_AccountPostJoin,
                    Password = item.Password_AccountPostJoin,
                    RoleID = (byte)item.RoleID_AccountPostJoin,
                    UserName = item.UserName_AccountPostJoin
                };

                obj.AccountAdminJoin = item.AdministratorID.HasValue ? new AccountObject()
                {
                    AccountID = (System.Guid)item.AdministratorID,
                    Active = item.Active_AccountAdminJoin == true,
                    Address = item.Address_AccountAdminJoin,
                    Avatar = item.Avatar_AccountAdminJoin,
                    BirthDay = item.BirthDay_AccountAdminJoin,
                    Email = item.Email_AccountAdminJoin,
                    FullName = item.FullName_AccountAdminJoin,
                    ID_Facebook = item.ID_Facebook_AccountAdminJoin,
                    ID_Gmail = item.ID_Gmail_AccountAdminJoin,
                    IsDeleted = item.IsDeleted_AccountAdminJoin == true,
                    JoinDay = item.JoinDay_AccountAdminJoin,
                    Mobile = item.Mobile_AccountAdminJoin,
                    NumberOfComment = item.NumberOfComment_AccountAdminJoin,
                    NumberOfFlow = item.NumberOfFlow_AccountAdminJoin,
                    NumberOfLikeProfile = item.NumberOfLikeProfile_AccountAdminJoin,
                    NumberOfPost = item.NumberOfPost_AccountAdminJoin,
                    Password = item.Password_AccountAdminJoin,
                    RoleID = (byte)item.RoleID_AccountAdminJoin,
                    UserName = item.UserName_AccountAdminJoin
                } : null;

                obj.CarStatusObjectJoin = new CarStatus_Object()
                {

                    CarStatusID = (System.Guid)item.CarStatusID,
                    CarStatusName = item.CarStatusName_CarStatusJoin,
                    IsDeleted = item.IsDeleted_CarStatusJoin == true
                };

                obj.FurnitureColorObjectJoin = new ExteriorFurnitureColor_Object()
                {

                    ExteriorFurnitureColorID = (System.Guid)item.FurnitureColorID,
                    ExteriorFurnitureColorName = item.ExteriorFurnitureColorName_FurnitureColorJoin,
                    IsDeleted = item.IsDeleted_FurnitureColorJoin == true
                };

                obj.ExteriorColorObjectJoin = new ExteriorFurnitureColor_Object()
                {

                    ExteriorFurnitureColorID = (System.Guid)item.ExteriorColorID,
                    ExteriorFurnitureColorName = item.ExteriorFurnitureColorName_ExteriorColorJoin,
                    IsDeleted = item.IsDeleted_ExteriorColorJoin == true
                };

                obj.FuelCarObjectJoin = new FuelCar_Object()
                {

                    FuelID = (System.Guid)item.FuelID,
                    FuelName = item.FuelName_FuelCarJoin,
                    IsDeleted = item.IsDeleted_FuelCarJoin == true
                };

                obj.GearCarObjectJoin = new GearCar_Object()
                {

                    CarGearId = (System.Guid)item.CarGearId,
                    CarGearName = item.CarGearName_GearCarJoin,
                    IsDeleted = item.IsDeleted_GearCarJoin == true
                };

                obj.MadeInCarObjectJoin = new MadeInCar_Object()
                {

                    IsDeleted = item.IsDeleted_MadeInCarJoin == true,
                    MadeInID = (System.Guid)item.MadeInId,
                    MadeInName = item.MadeInName_MadeInCarJoin
                };

                obj.NumberOfDoorObjectJoin = new NumberOfDoor_Object()
                {

                    IsDeleted = item.IsDeleted_NumberOfDoorJoin == true,
                    NumberOfDoorId = (System.Guid)item.NumberOfDoorId,
                    NumberOfDoorName = item.NumberOfDoorName_NumberOfDoorJoin
                };

                obj.NumberOfSeatObjectJoin = new NumberOfSeat_Object()
                {

                    IsDeleted = item.IsDeleted_NumberOfSeatJoin == true,
                    NumberOfSeatId = (System.Guid)item.NumberOfSeatId,
                    NumberOfSeatName = item.NumberOfSeatName_NumberOfSeatJoin
                };

                obj.SaleStatusCarObjectJoin = new SaleStatusCarObject()
                {

                    IsDeleted = item.IsDeleted_SaleStatusCarJoin == true,
                    SaleStatusCarID = (System.Guid)item.SaleStatusCarID,
                    SaleStatusCarName = item.SaleStatusCarName_SaleStatusCarJoin
                };

                obj.TypeOfCarObjectJoin = new TypeOfCar_Object()
                {

                    CompanyID = item.CompanyID_TypeOfCarJoin,
                    Description = item.Description_TypeOfCarJoin,
                    DesignID = item.DesignID_TypeOfCarJoin,
                    IsDeleted = item.IsDeleted_TypeOfCarJoin == true,
                    Status = item.Status_TypeOfCarJoin == true,
                    TypeName = item.TypeName_TypeOfCarJoin,
                    TypeOfCarID = (System.Guid)item.TypeOfCarID
                };

                obj.WheelDriveObjectJoin = new WheelDrive_Object()
                {

                    IsDeleted = item.IsDeleted_WheelDriveJoin == true,
                    WheelDriveId = (System.Guid)item.WheelDriveId,
                    WheelDriveName = item.WheelDriveName_WheelDriveJoin
                };

                obj.CityJoin = new City_Object()
                {
                    CityCode = item.CityCode,
                    CityId = item.CityId,
                    CityName = item.CityName,
                    IsDeleted = item.IsDeleted_City != true,
                    RegionId = item.RegionId.Value
                };

                lst.Add(obj);
            }
            return lst;
        }


        public PostObject GetByPostId(System.Guid PostId)
        {
            var list = new CarOnlineEntities().WEB_CARONLINE_SP_Post_GetByPostId(PostId);
            foreach (var item in list)
            {
                var obj = new PostObject();

                obj.AccountID = item.AccountID;
                obj.AdministratorID = item.AdministratorID;
                obj.Approved = item.Approved == true;
                obj.ApprovedDay = item.ApprovedDay;
                obj.CarGearId = item.CarGearId;
                obj.CarPrice = item.CarPrice;
                obj.CarStatusID = item.CarStatusID;
                obj.ExteriorColorID = item.ExteriorColorID;
                obj.FuelID = item.FuelID;
                obj.FurnitureColorID = item.FurnitureColorID;
                obj.IsDeleted = item.IsDeleted == true;
                obj.KmWent = item.KmWent;
                obj.LastContactDay = item.LastContactDay;
                obj.MadeInId = item.MadeInId;
                obj.Note = item.Note;
                obj.NumberOfDoorId = item.NumberOfDoorId;
                obj.NumberOfSeatId = item.NumberOfSeatId;
                obj.PostContent = item.PostContent;
                obj.PostDay = item.PostDay;
                obj.PostId = item.PostId;
                obj.PostTitle = item.PostTitle;
                obj.ProducedYear = item.ProducedYear;
                obj.SaleStatusCarID = item.SaleStatusCarID;
                obj.TypeOfCarID = item.TypeOfCarID;
                obj.UpdatePostDay = item.UpdatePostDay;
                obj.WheelDriveId = item.WheelDriveId;
                obj.AccountPostJoin = new AccountObject()
                {

                    AccountID = (System.Guid)item.AccountID,
                    Active = item.Active_AccountPostJoin == true,
                    Address = item.Address_AccountPostJoin,
                    Avatar = item.Avatar_AccountPostJoin,
                    BirthDay = item.BirthDay_AccountPostJoin,
                    Email = item.Email_AccountPostJoin,
                    FullName = item.FullName_AccountPostJoin,
                    ID_Facebook = item.ID_Facebook_AccountPostJoin,
                    ID_Gmail = item.ID_Gmail_AccountPostJoin,
                    IsDeleted = item.IsDeleted_AccountPostJoin == true,
                    JoinDay = item.JoinDay_AccountPostJoin,
                    Mobile = item.Mobile_AccountPostJoin,
                    NumberOfComment = item.NumberOfComment_AccountPostJoin,
                    NumberOfFlow = item.NumberOfFlow_AccountPostJoin,
                    NumberOfLikeProfile = item.NumberOfLikeProfile_AccountPostJoin,
                    NumberOfPost = item.NumberOfPost_AccountPostJoin,
                    Password = item.Password_AccountPostJoin,
                    RoleID = (byte)item.RoleID_AccountPostJoin,
                    UserName = item.UserName_AccountPostJoin
                };

                obj.AccountAdminJoin = new AccountObject()
                {

                    AccountID = (System.Guid)item.AdministratorID,
                    Active = item.Active_AccountAdminJoin == true,
                    Address = item.Address_AccountAdminJoin,
                    Avatar = item.Avatar_AccountAdminJoin,
                    BirthDay = item.BirthDay_AccountAdminJoin,
                    Email = item.Email_AccountAdminJoin,
                    FullName = item.FullName_AccountAdminJoin,
                    ID_Facebook = item.ID_Facebook_AccountAdminJoin,
                    ID_Gmail = item.ID_Gmail_AccountAdminJoin,
                    IsDeleted = item.IsDeleted_AccountAdminJoin == true,
                    JoinDay = item.JoinDay_AccountAdminJoin,
                    Mobile = item.Mobile_AccountAdminJoin,
                    NumberOfComment = item.NumberOfComment_AccountAdminJoin,
                    NumberOfFlow = item.NumberOfFlow_AccountAdminJoin,
                    NumberOfLikeProfile = item.NumberOfLikeProfile_AccountAdminJoin,
                    NumberOfPost = item.NumberOfPost_AccountAdminJoin,
                    Password = item.Password_AccountAdminJoin,
                    RoleID = (byte)item.RoleID_AccountAdminJoin,
                    UserName = item.UserName_AccountAdminJoin
                };

                obj.CarStatusObjectJoin = new CarStatus_Object()
                {

                    CarStatusID = (System.Guid)item.CarStatusID,
                    CarStatusName = item.CarStatusName_CarStatusJoin,
                    IsDeleted = item.IsDeleted_CarStatusJoin == true
                };

                obj.FurnitureColorObjectJoin = new ExteriorFurnitureColor_Object()
                {

                    ExteriorFurnitureColorID = (System.Guid)item.FurnitureColorID,
                    ExteriorFurnitureColorName = item.ExteriorFurnitureColorName_FurnitureColorJoin,
                    IsDeleted = item.IsDeleted_FurnitureColorJoin == true
                };

                obj.ExteriorColorObjectJoin = new ExteriorFurnitureColor_Object()
                {

                    ExteriorFurnitureColorID = (System.Guid)item.ExteriorColorID,
                    ExteriorFurnitureColorName = item.ExteriorFurnitureColorName_ExteriorColorJoin,
                    IsDeleted = item.IsDeleted_ExteriorColorJoin == true
                };

                obj.FuelCarObjectJoin = new FuelCar_Object()
                {

                    FuelID = (System.Guid)item.FuelID,
                    FuelName = item.FuelName_FuelCarJoin,
                    IsDeleted = item.IsDeleted_FuelCarJoin == true
                };

                obj.GearCarObjectJoin = new GearCar_Object()
                {

                    CarGearId = (System.Guid)item.CarGearId,
                    CarGearName = item.CarGearName_GearCarJoin,
                    IsDeleted = item.IsDeleted_GearCarJoin == true
                };

                obj.MadeInCarObjectJoin = new MadeInCar_Object()
                {

                    IsDeleted = item.IsDeleted_MadeInCarJoin == true,
                    MadeInID = (System.Guid)item.MadeInId,
                    MadeInName = item.MadeInName_MadeInCarJoin
                };

                obj.NumberOfDoorObjectJoin = new NumberOfDoor_Object()
                {

                    IsDeleted = item.IsDeleted_NumberOfDoorJoin == true,
                    NumberOfDoorId = (System.Guid)item.NumberOfDoorId,
                    NumberOfDoorName = item.NumberOfDoorName_NumberOfDoorJoin
                };

                obj.NumberOfSeatObjectJoin = new NumberOfSeat_Object()
                {

                    IsDeleted = item.IsDeleted_NumberOfSeatJoin == true,
                    NumberOfSeatId = (System.Guid)item.NumberOfSeatId,
                    NumberOfSeatName = item.NumberOfSeatName_NumberOfSeatJoin
                };

                obj.SaleStatusCarObjectJoin = new SaleStatusCarObject()
                {

                    IsDeleted = item.IsDeleted_SaleStatusCarJoin == true,
                    SaleStatusCarID = (System.Guid)item.SaleStatusCarID,
                    SaleStatusCarName = item.SaleStatusCarName_SaleStatusCarJoin
                };

                obj.TypeOfCarObjectJoin = new TypeOfCar_Object()
                {

                    CompanyID = item.CompanyID_TypeOfCarJoin,
                    Description = item.Description_TypeOfCarJoin,
                    DesignID = item.DesignID_TypeOfCarJoin,
                    IsDeleted = item.IsDeleted_TypeOfCarJoin == true,
                    Status = item.Status_TypeOfCarJoin == true,
                    TypeName = item.TypeName_TypeOfCarJoin,
                    TypeOfCarID = (System.Guid)item.TypeOfCarID
                };

                obj.WheelDriveObjectJoin = new WheelDrive_Object()
                {

                    IsDeleted = item.IsDeleted_WheelDriveJoin == true,
                    WheelDriveId = (System.Guid)item.WheelDriveId,
                    WheelDriveName = item.WheelDriveName_WheelDriveJoin
                };

                obj.CityJoin = new City_Object()
                {
                    CityCode = item.CityCode,
                    CityId = item.CityId,
                    CityName = item.CityName,
                    IsDeleted = item.IsDeleted_City != true,
                    RegionId = item.RegionId.Value
                };

                return obj;
            }
            return null;
        }


        public bool Insert(PostObject ob)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_Post_Insert(ob.AccountID, ob.AdministratorID, ob.Approved, ob.ApprovedDay, ob.CarGearId, ob.CarPrice, ob.CarStatusID, ob.ExteriorColorID, ob.FuelID, ob.FurnitureColorID, ob.IsDeleted, ob.KmWent, ob.LastContactDay, ob.MadeInId, ob.Note, ob.NumberOfDoorId, ob.NumberOfSeatId, ob.PostContent, ob.PostDay, ob.PostId, ob.PostTitle, ob.ProducedYear, ob.SaleStatusCarID, ob.TypeOfCarID, ob.UpdatePostDay, ob.WheelDriveId) > 0;
        }


        public bool Delete(System.Guid PostId)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_Post_Delete(PostId) > 0;
        }


        public bool Update(PostObject ob)
        {
            return new CarOnlineEntities().WEB_CARONLINE_SP_Post_Update(ob.AccountID, ob.AdministratorID, ob.Approved, ob.ApprovedDay, ob.CarGearId, ob.CarPrice, ob.CarStatusID, ob.ExteriorColorID, ob.FuelID, ob.FurnitureColorID, ob.IsDeleted, ob.KmWent, ob.LastContactDay, ob.MadeInId, ob.Note, ob.NumberOfDoorId, ob.NumberOfSeatId, ob.PostContent, ob.PostDay, ob.PostId, ob.PostTitle, ob.ProducedYear, ob.SaleStatusCarID, ob.TypeOfCarID, ob.UpdatePostDay, ob.WheelDriveId) > 0;
        }


        public List<PostObject> GetByDateCreate_Paging(int pageIndex, int pageSize, int? Location)
        {
            using (var db = new CarOnlineEntities())
            {
                var data = db.WEB_CARONLINE_SP_Post_GetByDateCreate_Paging(pageIndex, pageSize, Location).ToList();
                var list = new List<PostObject>();
                list.AddRange(data.Select(item => new PostObject
                {
                    AccountID = item.AccountID,
                    CarCode = item.Carcode,
                    CarPrice = item.CarPrice,
                    CarStatusID = item.CarStatusID,
                    KmWent = item.KmWent,
                    LastContactDay = item.LastContactDay,
                    MadeInId = item.MadeInId,
                    Note = item.Note,
                    PostContent = item.PostContent,
                    PostDay = item.PostDay,
                    PostId = item.PostId,
                    PostTitle = item.PostTitle,
                    SaleStatusCarID = item.SaleStatusCarID,
                    TypeOfCarID = item.TypeOfCarID,
                    AccountPostJoin = new AccountObject()
                    {
                        AccountID = item.AccountID.GetValueOrDefault(),
                        Address = item.Address_AccountPostJoin,
                        FullName = item.FullName_AccountPostJoin,
                    },

                    CarStatusObjectJoin = new CarStatus_Object()
                    {
                        CarStatusID = item.CarStatusID.GetValueOrDefault(),
                    },

                    MadeInCarObjectJoin = new MadeInCar_Object()
                    {
                        MadeInID = item.MadeInId.GetValueOrDefault(),
                    },

                    SaleStatusCarObjectJoin = new SaleStatusCarObject()
                    {
                        SaleStatusCarID = item.SaleStatusCarID.GetValueOrDefault(),
                    },

                    TypeOfCarObjectJoin = new TypeOfCar_Object()
                    {
                        TypeOfCarID = item.TypeOfCarID.GetValueOrDefault()
                    },
                    ImageObjectFirstShow = new Image_Object
                    {

                        //ImageName = item.ImageName,
                        //ImageAlt = item.ImageAlt,
                        //Rank = item.Rank
                    }

                }));
                return list;
            }
        }

        public PostObject GetByCode(long? carCode)
        {
            using (var db = new CarOnlineEntities())
            {
                var obj = db.WEB_CARONLINE_SP_Post_getbycode(carCode).FirstOrDefault();
                return obj != null ? new PostObject
                {
                    PostId = obj.PostId,
                    CarCode = obj.Carcode,
                    MadeInId = obj.MadeInId,
                    CarStatusID = obj.CarStatusID,
                    TypeOfCarID = obj.TypeOfCarID,
                    KmWent = obj.KmWent,
                    FurnitureColorID = obj.FurnitureColorID,
                    ExteriorColorID = obj.ExteriorColorID,
                    NumberOfDoorId = obj.NumberOfDoorId,
                    NumberOfSeatId = obj.NumberOfSeatId,
                    FuelID = obj.FuelID,
                    CarGearId = obj.CarGearId,
                    WheelDriveId = obj.WheelDriveId,
                    CarPrice = obj.CarPrice,
                    ProducedYear = obj.ProducedYear,
                    PostDay = obj.PostDay,
                    PostContent = obj.PostContent,
                    AccountID = obj.AccountID,
                    PostTitle = obj.PostTitle,
                    UpdatePostDay = obj.UpdatePostDay,
                    SaleStatusCarID = obj.SaleStatusCarID,
                    LastContactDay = obj.LastContactDay,
                    Approved = obj.Approved.GetValueOrDefault(),
                    IsDeleted = obj.IsDeleted.GetValueOrDefault(),
                    AdministratorID = obj.AdministratorID,
                    ApprovedDay = obj.ApprovedDay,
                    Note = obj.Note,
                    WheelDriveObjectJoin = new WheelDrive_Object
                    {
                        WheelDriveName = obj.WheelDriveName
                    },
                    NumberOfDoorObjectJoin = new NumberOfDoor_Object { NumberOfDoorName = obj.NumberOfDoorName },
                    NumberOfSeatObjectJoin = new NumberOfSeat_Object { NumberOfSeatName = obj.NumberOfSeatName },
                    CarStatusObjectJoin = new CarStatus_Object { CarStatusName = obj.CarStatusName },
                    GearCarObjectJoin = new GearCar_Object { CarGearName = obj.CarGearName },
                    FuelCarObjectJoin = new FuelCar_Object { FuelName = obj.FuelName },
                    TypeOfCarObjectJoin = new TypeOfCar_Object
                    {
                        CompanyID = obj.CompanyID,
                        Description = obj.Description,
                        DesignID = obj.DesignID,
                        TypeName = obj.TypeName,
                        Status = obj.Status,
                        CompanyCarObject = new CompanyCar_Object { CompanyName = obj.CompanyName },
                        DesignCarObject = new DesignCar_Object { DesignName = obj.DesignName }
                    },
                    MadeInCarObjectJoin = new MadeInCar_Object
                    {
                        MadeInName = obj.MadeInName
                    },
                    ExteriorColorObjectJoin = new ExteriorFurnitureColor_Object
                    {
                        ExteriorFurnitureColorName = obj.ExteriorFurnitureColorName
                    },
                    ImageObjectFirstShow = new Image_Object
                    {
                        PostImageId = obj.PostImageID,
                        ImageName = obj.ImageName,
                        ImageAlt = obj.ImageAlt,
                        Rank = obj.Rank
                    }
                } : null;
            }
        }



    }
}
