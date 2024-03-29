﻿using AutoMapper;
using IczpNet.Connection.Dtos;

namespace IczpNet.Connection;

public class ConnectionApplicationAutoMapperProfile : Profile
{
    public ConnectionApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        CreateMap<ConnectionCreateInput, Connections.Connection>().IgnoreAllPropertiesWithAnInaccessibleSetter();

        CreateMap<Connections.Connection, ConnectionDto>();
    }
}
