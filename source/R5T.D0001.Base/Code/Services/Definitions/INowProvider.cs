using System;
using System.Threading.Tasks;


namespace R5T.D0001
{
    public interface INowProvider
    {
        DateTime GetNow();
        Task<DateTime> GetNowAsync();
    }
}
