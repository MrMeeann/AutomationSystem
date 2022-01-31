﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Office_Automation_DatabaseEntities : DbContext
    {
        public Office_Automation_DatabaseEntities()
            : base("name=Office_Automation_DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vw_Users> Vw_Users { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<Vw_Reminder> Vw_Reminder { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<Vw_UserLog> Vw_UserLog { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Vw_Jobs> Vw_Jobs { get; set; }
        public virtual DbSet<AsignmentJob> AsignmentJobs { get; set; }
        public virtual DbSet<Vw_AsignmentJobs> Vw_AsignmentJobs { get; set; }
        public virtual DbSet<Letter> Letters { get; set; }
        public virtual DbSet<Vw_Letters> Vw_Letters { get; set; }
    
        public virtual int Sp_InsterUsers(string userFirstName, string userLastName, string userName, string userPassword, string userPersonalID, string userEmail, Nullable<byte> userGender, Nullable<byte> userActivity, string userTel, string userBrithDate, byte[] userImage, byte[] userSignature, string userRegisteredDate)
        {
            var userFirstNameParameter = userFirstName != null ?
                new ObjectParameter("UserFirstName", userFirstName) :
                new ObjectParameter("UserFirstName", typeof(string));
    
            var userLastNameParameter = userLastName != null ?
                new ObjectParameter("UserLastName", userLastName) :
                new ObjectParameter("UserLastName", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("UserPassword", userPassword) :
                new ObjectParameter("UserPassword", typeof(string));
    
            var userPersonalIDParameter = userPersonalID != null ?
                new ObjectParameter("UserPersonalID", userPersonalID) :
                new ObjectParameter("UserPersonalID", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("UserEmail", userEmail) :
                new ObjectParameter("UserEmail", typeof(string));
    
            var userGenderParameter = userGender.HasValue ?
                new ObjectParameter("UserGender", userGender) :
                new ObjectParameter("UserGender", typeof(byte));
    
            var userActivityParameter = userActivity.HasValue ?
                new ObjectParameter("UserActivity", userActivity) :
                new ObjectParameter("UserActivity", typeof(byte));
    
            var userTelParameter = userTel != null ?
                new ObjectParameter("UserTel", userTel) :
                new ObjectParameter("UserTel", typeof(string));
    
            var userBrithDateParameter = userBrithDate != null ?
                new ObjectParameter("UserBrithDate", userBrithDate) :
                new ObjectParameter("UserBrithDate", typeof(string));
    
            var userImageParameter = userImage != null ?
                new ObjectParameter("UserImage", userImage) :
                new ObjectParameter("UserImage", typeof(byte[]));
    
            var userSignatureParameter = userSignature != null ?
                new ObjectParameter("UserSignature", userSignature) :
                new ObjectParameter("UserSignature", typeof(byte[]));
    
            var userRegisteredDateParameter = userRegisteredDate != null ?
                new ObjectParameter("UserRegisteredDate", userRegisteredDate) :
                new ObjectParameter("UserRegisteredDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_InsterUsers", userFirstNameParameter, userLastNameParameter, userNameParameter, userPasswordParameter, userPersonalIDParameter, userEmailParameter, userGenderParameter, userActivityParameter, userTelParameter, userBrithDateParameter, userImageParameter, userSignatureParameter, userRegisteredDateParameter);
        }
    
        public virtual int Sp_UpdateUsers(Nullable<int> userID, string userFirstName, string userLastName, string userPersonalID, string userEmail, Nullable<byte> userGender, string userTel, string userBrithDate, byte[] userImage)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var userFirstNameParameter = userFirstName != null ?
                new ObjectParameter("UserFirstName", userFirstName) :
                new ObjectParameter("UserFirstName", typeof(string));
    
            var userLastNameParameter = userLastName != null ?
                new ObjectParameter("UserLastName", userLastName) :
                new ObjectParameter("UserLastName", typeof(string));
    
            var userPersonalIDParameter = userPersonalID != null ?
                new ObjectParameter("UserPersonalID", userPersonalID) :
                new ObjectParameter("UserPersonalID", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("UserEmail", userEmail) :
                new ObjectParameter("UserEmail", typeof(string));
    
            var userGenderParameter = userGender.HasValue ?
                new ObjectParameter("UserGender", userGender) :
                new ObjectParameter("UserGender", typeof(byte));
    
            var userTelParameter = userTel != null ?
                new ObjectParameter("UserTel", userTel) :
                new ObjectParameter("UserTel", typeof(string));
    
            var userBrithDateParameter = userBrithDate != null ?
                new ObjectParameter("UserBrithDate", userBrithDate) :
                new ObjectParameter("UserBrithDate", typeof(string));
    
            var userImageParameter = userImage != null ?
                new ObjectParameter("UserImage", userImage) :
                new ObjectParameter("UserImage", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_UpdateUsers", userIDParameter, userFirstNameParameter, userLastNameParameter, userPersonalIDParameter, userEmailParameter, userGenderParameter, userTelParameter, userBrithDateParameter, userImageParameter);
        }
    
        public virtual int Sp_UpdateUsers_WithoutImage(Nullable<int> userID, string userFirstName, string userLastName, string userPersonalID, string userEmail, Nullable<byte> userGender, string userTel, string userBrithDate)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var userFirstNameParameter = userFirstName != null ?
                new ObjectParameter("UserFirstName", userFirstName) :
                new ObjectParameter("UserFirstName", typeof(string));
    
            var userLastNameParameter = userLastName != null ?
                new ObjectParameter("UserLastName", userLastName) :
                new ObjectParameter("UserLastName", typeof(string));
    
            var userPersonalIDParameter = userPersonalID != null ?
                new ObjectParameter("UserPersonalID", userPersonalID) :
                new ObjectParameter("UserPersonalID", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("UserEmail", userEmail) :
                new ObjectParameter("UserEmail", typeof(string));
    
            var userGenderParameter = userGender.HasValue ?
                new ObjectParameter("UserGender", userGender) :
                new ObjectParameter("UserGender", typeof(byte));
    
            var userTelParameter = userTel != null ?
                new ObjectParameter("UserTel", userTel) :
                new ObjectParameter("UserTel", typeof(string));
    
            var userBrithDateParameter = userBrithDate != null ?
                new ObjectParameter("UserBrithDate", userBrithDate) :
                new ObjectParameter("UserBrithDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_UpdateUsers_WithoutImage", userIDParameter, userFirstNameParameter, userLastNameParameter, userPersonalIDParameter, userEmailParameter, userGenderParameter, userTelParameter, userBrithDateParameter);
        }
    
        public virtual int Sp_Update_ExitDate(Nullable<int> logUserID, string logUserExitDate)
        {
            var logUserIDParameter = logUserID.HasValue ?
                new ObjectParameter("LogUserID", logUserID) :
                new ObjectParameter("LogUserID", typeof(int));
    
            var logUserExitDateParameter = logUserExitDate != null ?
                new ObjectParameter("LogUserExitDate", logUserExitDate) :
                new ObjectParameter("LogUserExitDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Update_ExitDate", logUserIDParameter, logUserExitDateParameter);
        }
    
        public virtual ObjectResult<Sp_ShowAllUserInfo_Result> Sp_ShowAllUserInfo(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_ShowAllUserInfo_Result>("Sp_ShowAllUserInfo", userIDParameter);
        }
    }
}
