using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Evotec.DTO;
using Evotec.Modelo;

namespace Evotec.Utilidades
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<Usuario, SesionDTO>();
            CreateMap<UsuarioDTO, Usuario>();

            CreateMap<Estado, EstadoDTO>();
            CreateMap<EstadoDTO, Estado>();

            CreateMap<Tarea, TareaDTO>();
            CreateMap<TareaDTO, Tarea>().ForMember(destino => 
            destino.IdEstadoNavigation,
            opt => opt.Ignore()
            );

        }
    }
}
