using AutoMapper;
using Vidly_AppStart;

namespace Vidly
{
    public static class AutomapperWebConfiguration
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            return config;
        }
    }
}