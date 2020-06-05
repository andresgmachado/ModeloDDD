using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using System;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig 
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });

        }

    }
}