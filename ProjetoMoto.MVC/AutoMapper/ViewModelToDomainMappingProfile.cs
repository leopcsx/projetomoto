using ProjetoMoto.Data.Entities;
using ProjetoMoto.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ProjetoMoto.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MotoristaViewModel, Motorista>();
            CreateMap<ContratadaViewModel, Contratada>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}