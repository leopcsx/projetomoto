using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoMoto.Data.Entities;
using ProjetoMoto.MVC.Models;

namespace ProjetoMoto.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Motorista, MotoristaViewModel>();
            CreateMap<Contratada, ContratadaViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}