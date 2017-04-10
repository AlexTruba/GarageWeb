﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Configuration;
using System.Threading;

namespace GarageWeb.Models.ViewModel
{
    public class ChangeLoginViewModel
    {
        public bool IsSelected { get; set; }

        [Required(ErrorMessage = "Логін обов'язковий для введення!")]
        [Display(Name = "Новий Логін")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пароль обов'язковий для введення!")]
        [DataType(DataType.Password)]
        [Display(Name = "Новий Пароль")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Пароль обов'язковий для введення!")]
        [DataType(DataType.Password)]
        [Display(Name = "Старий Пароль")]
        public string OldPassword { get; set; }

        //public ChangeLoginViewModel()
        //{
        //    Login = WebConfigurationManager.AppSettings["AdminLogin"];
        //}

        Microsoft.Owin.Security.Infrastructure.AuthenticationHandler
    }
}