using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMoto.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<ViewModelToDomainMappingProfile>();
                config.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}