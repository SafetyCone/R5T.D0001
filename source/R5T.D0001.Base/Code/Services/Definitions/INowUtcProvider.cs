using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0001
{
    [ServiceDefinitionMarker]
    public interface INowUtcProvider : IServiceDefinition
    {
        Task<DateTime> GetNowUtc();
    }
}
