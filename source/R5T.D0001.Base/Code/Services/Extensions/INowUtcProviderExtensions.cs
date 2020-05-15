using System;
using System.Threading.Tasks;


namespace R5T.D0001
{
    public static class INowUtcProviderExtensions
    {
        public static async Task<DateTime> GetNowAsync(INowUtcProvider nowUtcProvider)
        {
            var utcNow = await nowUtcProvider.GetNowUtcAsync();

            var now = utcNow.ToLocalTime();
            return now;
        }
    }
}
