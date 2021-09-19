using AutoMapper;
using VoetbalAdmin.DataContracts.DTO;
using VoetbalAdmin.DAL.Entities;
using System;

namespace VoetbalAdmin.BLL.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Geslacht, GeslachtDTO>()
                .ForMember(p => p.Naam, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<Lid, LidDTO>()
                .ForMember(p => p.BondsNr, opt => opt.DoNotAllowNull())
                .ForMember(p => p.Voornaam, opt => opt.DoNotAllowNull())
                .ForMember(p => p.Naam, opt => opt.DoNotAllowNull())
                .ForMember(p => p.GeslachtId, opt => opt.DoNotAllowNull())
                .ForMember(p => p.Postcode, opt => opt.DoNotAllowNull())
                .ForMember(p => p.Adres, opt => opt.DoNotAllowNull())
                .ForMember(p => p.IsGearchiveerd, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<LidRol, LidRolDTO>()
                .ForMember(p => p.LidId, opt => opt.DoNotAllowNull())
                .ForMember(p => p.RolId, opt => opt.DoNotAllowNull())
                .ForMember(p => p.Begindatum, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<Reeks, ReeksDTO>()
                .ForMember(p => p.Naam, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<Rol, RolDTO>()
                .ForMember(p => p.Naam, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<Seizoen, SeizoenDTO>()
                .ForMember(p => p.Naam, opt => opt.DoNotAllowNull())
                .ForMember(p => p.Begindatum, opt => opt.DoNotAllowNull())
                .ForMember(p => p.IsActief, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<Team, TeamDTO>()
                .ForMember(p => p.Naam, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<Wedstrijd, WedstrijdDTO>()
                .ForMember(p => p.TeamThuisId, opt => opt.DoNotAllowNull())
                .ForMember(p => p.TeamUitId, opt => opt.DoNotAllowNull())
                .ReverseMap();
            CreateMap<WedstrijdResultaat, WedstrijdResultaatDTO>()
                .ForMember(p => p.WedstrijdId, opt => opt.DoNotAllowNull())
                .ReverseMap();
        }
    }
}
