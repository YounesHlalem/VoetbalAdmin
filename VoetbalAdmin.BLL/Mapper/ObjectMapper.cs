using AutoMapper;
using System;

namespace VoetbalAdmin.BLL.Mapper
{
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            MapperConfiguration config = new MapperConfiguration(mc => {
                mc.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                mc.AddProfile<MapperProfile>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
