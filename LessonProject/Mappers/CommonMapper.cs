using AutoMapper;
using LessonProject.Model;
using LessonProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonProject.Mappers
{
    public class CommonMapper : IMapper
    {
        static CommonMapper()
        {

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<User, UserView>();
            //    cfg.CreateMap<UserView, User>();
            //});

            //Mapper.CreateMap<User, UserView>();
            //Mapper.CreateMap<UserView, User>();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserView>();
                cfg.CreateMap<UserView, User>();
            });
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}