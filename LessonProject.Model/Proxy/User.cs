﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LessonProject.Model
{
    public partial class User : IValidatableObject
    {
        public static string GetActivateUrl()
        {
            return Guid.NewGuid().ToString("N");
        }
        public string ConfirmPassword { get; set; }

        public string Captcha { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //не нулевой Email
            if (string.IsNullOrWhiteSpace(Email))
            {
                yield return new ValidationResult("Введите email", new string[] { "Email" });
                Email = "";
            }

            //корректный Email
            var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled);
            var match = regex.Match(Email);
            if (!(match.Success && match.Length == Email.Length))
            {
                yield return new ValidationResult("Введите корректный email", new string[] { "Email" });
            }

            //пароль не нулевой
            if (string.IsNullOrWhiteSpace(Password))
            {
                yield return new ValidationResult("Введите пароль", new string[] { "Password" });
            }

            //пароли совпадают
            if (Password != ConfirmPassword)
            {
                yield return new ValidationResult("Пароли не совпадают", new string[] { "ConfirmPassword" });
            }

            //check git options
        }

    }
}