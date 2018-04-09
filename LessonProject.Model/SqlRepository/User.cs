﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonProject.Model
{
    public partial class SqlRepository
    {


        public IQueryable<User> Users
        {
            get
            {
                return Db.Users;
            }
        }

        public bool CreateUser(User instance)
        {
            if (instance.ID == 0)
            {
                instance.AddedDate = DateTime.Now;
                instance.ActivatedLink = User.GetActivateUrl();
                Db.Users.InsertOnSubmit(instance);
                Db.Users.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateUser(User instance)
        {
            User cache = Db.Users.Where(p => p.ID == instance.ID).FirstOrDefault();
            if (cache != null)
            {
                cache.AvatarPath = instance.AvatarPath;
                cache.Email = instance.Email;
                Db.Users.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveUser(int idUser)
        {
            User instance = Db.Users.Where(p => p.ID == idUser).FirstOrDefault();
            if (instance != null)
            {
                Db.Users.DeleteOnSubmit(instance);
                Db.Users.Context.SubmitChanges();
                return true;
            }

            return false;
        }

    }
}
