
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Interfell.Store.Module.Commons.DTO;
using Interfell.Store.Data.Entities.Entity;

#endregion

namespace Interfell.Store.Data.Model
{
    public class ConfigureAutomapper: Profile
    {


        public ConfigureAutomapper()
        {
            CreateMap<Stores, StoreDTO>().ReverseMap();
            CreateMap<Articles, ArticleDTO>().ReverseMap();
        }

        /// <summary>
        /// Init automapper
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(cfg=> 
            {
                cfg.AddProfile<ConfigureAutomapper>();
            });
        }


    }
}
