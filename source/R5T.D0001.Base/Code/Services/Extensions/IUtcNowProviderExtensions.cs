using System;
using System.Threading.Tasks;


namespace R5T.D0001
{
    public static class IUtcNowProviderExtensions
    {
        public static async Task<DateTime> GetNow(IUtcNowProvider utcNowProvider)
        {
            var utcNow = await utcNowProvider.GetUtcNowAsync();

            var now = utcNow.ToLocalTime();
            return now;
        }
    }
}
