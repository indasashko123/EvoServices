using AutoMapper;
using System.Reflection;
using WalletService.Application.Interfaces;

namespace WalletService.Application.Mapping
{
    public class AssemblyMappingProfile : Profile
    {
        public AssemblyMappingProfile(Assembly assembly) 
        {
            AssemblyMappingsFromAssembly(assembly);
        }
        private void AssemblyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes().
                Where(type => type.GetInterfaces().
                Any(iface => iface.IsGenericType &&
                iface.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
