﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class UserBLL
    {

        #region DIRECT PROPERTIES


        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string PasswordHash { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public string PasswordSalt { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public int RoleID { get; set; }


        #endregion


        #region INDIRECT PROPERTIES


        // ----- Roles Properties ----- //
        public string RoleName { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public string RolePermissions { get; set; }


        #endregion


        public UserBLL()
        {

        }


        public UserBLL(UserDAL dal)
        {
            this.UserID = dal.UserID;
            this.UserName = dal.UserName;
            this.UserEmail = dal.UserEmail;
            this.PasswordHash = dal.PasswordHash;
            this.PasswordSalt = dal.PasswordSalt;
            this.RoleID = dal.RoleID;

            // ----- Roles Properties ----- //
            this.RoleName = dal.RoleName;
            this.RolePermissions = dal.RolePermissions;
        }

    }
}
