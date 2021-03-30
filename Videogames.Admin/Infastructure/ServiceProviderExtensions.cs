﻿using Microsoft.Extensions.DependencyInjection;
using Videogames.Admin.Models.Common.Developers.CreateEdit;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.Admin.Models.Common.Developers.List;
using Videogames.Admin.Models.Common.Genres.CreateEdit;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.Admin.Models.Common.Genres.List;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;
using Videogames.DataLayer;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres.Repositories;
using Videogames.DataLayer.Entities.Videogames.Interfaces;
using Videogames.DataLayer.Entities.Videogames.Repositories;

namespace Videogames.Admin.Infastructure
{
    public static class ServiceProviderExtensions
    {
        public static void AddBuilders(this IServiceCollection services)
        {
            services.AddDbContext<VideogameDbContext>(ServiceLifetime.Transient);

            services.AddSingleton<IVideogameRepository, VideogameRepository>();
            services.AddSingleton<IVideogameModelHandler, VideogameModel>();
            //
            services.AddSingleton<IGenreRepository, GenreRepository>();
            services.AddSingleton<IGenreModelHandler, GenreModelHandler>();
            services.AddSingleton<IGenreStructureFormHandler, GenreStructureFormHandler>();
            services.AddSingleton<IGenreListModelBuilder, GenreListModelBuilder>();
            services.AddSingleton<IGenreItemModelBuilder, GenreItemModelBuilder>();
            //
            services.AddSingleton<IDeveloperRepository, DeveloperRepository>();
            services.AddSingleton<IDeveloperModelHandler, DeveloperModelHandler>();
            services.AddSingleton<IDeveloperStructureFormHandler, DeveloperStructureFormHandler>();
            services.AddSingleton<IDeveloperItemModelBuilder, DeveloperItemModelBuilder>();
            services.AddSingleton<IDeveloperListModelBuilder, DeveloperListModelBuilder>();
            
            
        }
    }
}
