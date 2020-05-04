﻿using GenFu;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class RestaurantOwnerConfig
    {
        public RestaurantOwnerConfig(EntityTypeBuilder<RestaurantOwner> entityBuilder)
        {
            var id = 0;
            var dni = 10000000;
            A.Configure<RestaurantOwner>()
                .Fill(x => x.RestaurantOwnerId, () => { return id++; })
                .Fill(x => x.Name).AsFirstName()
                .Fill(x => x.LastName).AsLastName()
                .Fill(x => x.Dni, () => { return dni++.ToString(); })
                .Fill(x => x.Email, x => $"{x.Name}.{x.LastName}@hotmail.com")
                .Fill(x => x.Username, x => $"{x.Dni}")
                .Fill(x => x.Password, new Guid());

            var RestaurantOwners = A.ListOf<RestaurantOwner>(5);
            entityBuilder.HasData(RestaurantOwners);

        }
    }
}
