using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class ConstantValueUtcNowProvider : IUtcNowProvider
    {
        #region Static

        public static ConstantValueUtcNowProvider NewFromUtcNow(DateTime utcNow)
        {
            var constantValueUtcNowProvider = new ConstantValueUtcNowProvider(utcNow);
            return constantValueUtcNowProvider;
        }

        public static ConstantValueUtcNowProvider New(DateTime utcNow)
        {
            var constantValueUtcNowProvider = ConstantValueUtcNowProvider.NewFromUtcNow(utcNow);
            return constantValueUtcNowProvider;
        }

        public static ConstantValueUtcNowProvider NewFromLocalNow(DateTime localNow)
        {
            var utcNow = localNow.ToUniversalTime();

            var constantValueUtcNowProvider = new ConstantValueUtcNowProvider(utcNow);
            return constantValueUtcNowProvider;
        }

        public static ConstantValueUtcNowProvider NewFromOffset(TimeSpan offset)
        {
            var offsetUtcNow = DateTime.UtcNow + offset;

            var constantValueUtcNowProvider = ConstantValueUtcNowProvider.NewFromUtcNow(offsetUtcNow);
            return constantValueUtcNowProvider;
        }

        #endregion


        private DateTime UtcNow { get; }


        public ConstantValueUtcNowProvider(DateTime utcNow)
        {
            this.UtcNow = utcNow;
        }

        public Task<DateTime> GetUtcNowAsync()
        {
            return Task.FromResult(this.UtcNow);
        }
    }
}
