using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0001.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// Returns the <see cref="DateTime.UtcNow"/> value.
    /// </summary>
    public class NowUtcProvider : INowUtcProvider,IServiceImplementation
    {
        public Task<DateTime> GetNowUtc()
        {
            var nowUtc = DateTime.UtcNow;

            return Task.FromResult(nowUtc);
        }
    }
}
