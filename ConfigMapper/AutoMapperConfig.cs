﻿using AutoMapper;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.ConfigMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Order
            CreateMap<Order, OrderDto>();
            CreateMap<DataCollection<Order>,DataCollection<OrderDto>>();
            CreateMap<OrderCreateDto, Order>();

            CreateMap<OrderDetailCreateDto, OrderDetail>();

            //Extra
            CreateMap<Extra, ExtraDto>();
            CreateMap<DataCollection<Extra>, DataCollection<ExtraDto>>();
            CreateMap<ExtraCreateDto, Extra>();

            //Card
            CreateMap<Card, CardDto>();
            CreateMap<DataCollection<Card>, DataCollection<CardDto>>();
            CreateMap<CardCreateDto, Card>();

            //Client
            CreateMap<Client, ClientDto>();
            CreateMap<DataCollection<Client>, DataCollection<ClientDto>>();
            CreateMap<ClientCreateDto, Client>();

            //Table
            CreateMap<Table, TableDto>();
            CreateMap<DataCollection<Table>, DataCollection<TableDto>>();
            CreateMap<TableCreateDto, TableDto>();

            //Dish
            CreateMap<Dish, DishDto>();
            CreateMap<DataCollection<Dish>, DataCollection<DishDto>>();
            CreateMap<DishCreateDto, Dish>();

            //Restaurant
            CreateMap<Restaurant, RestaurantDto>();
            CreateMap<DataCollection<Restaurant>, DataCollection<RestaurantDto>>();
            CreateMap<RestaurantCreateDto, Restaurant>();

            //Restaurant Owner
            CreateMap<RestaurantOwner, RestaurantOwnerDto>();
            CreateMap<DataCollection<RestaurantOwner>, DataCollection<RestaurantOwnerDto>>();
            CreateMap<RestaurantOwnerDto, RestaurantOwner>();
        }
    }
}
