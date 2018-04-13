using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonProject.Models.ViewModels
{
    public class UserView
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Captcha { get; set; }

        public string AvatarPath { get; set; }
    }
}