using System;
using System.Threading.Tasks;


namespace R5T.D0001
{
    public interface INowUtcProvider
    {
        Task<DateTime> GetNowUtcAsync();
    }
}
