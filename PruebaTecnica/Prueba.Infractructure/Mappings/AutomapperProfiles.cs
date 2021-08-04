using AutoMapper;
using Prueba.Core.DTOS;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Infractructure.Mappings
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Estado, EstadoDto>();
            CreateMap<EstadoDto, Estado>();
            CreateMap<Equipo, EquipoDto>();
            CreateMap <EquipoDto,Equipo> ();

            CreateMap <Jugador,JugadorDto> ();
            CreateMap <JugadorDto,Jugador> ();

            CreateMap <Pais,PaisDto> ();
            CreateMap <PaisDto,Pais> ();
        }
    }
}
