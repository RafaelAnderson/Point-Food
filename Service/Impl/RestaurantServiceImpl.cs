﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class RestaurantServiceImpl : IRestaurantService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RestaurantServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DataCollection<RestaurantDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<RestaurantDto>>(
                _context.Restaurants.OrderByDescending(x => x.RestaurantId)
                .Include(x => x.RestaurantOwner)
                .AsQueryable()
                .Paged(page, take)
                );
        }
    }
}
