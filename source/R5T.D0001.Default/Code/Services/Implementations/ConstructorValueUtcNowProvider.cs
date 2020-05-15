using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class ConstructorValueUtcNowProvider : IUtcNowProvider
    {
        #region Static

        public static ConstructorValueUtcNowProvider NewFromUtcNow(DateTime utcNow)
        {
            var constantValueUtcNowProvider = new ConstructorValueUtcNowProvider(utcNow);
            return constantValueUtcNowProvider;
        }

        /// <summary>
        /// Uses the <see cref="ConstructorValueUtcNowProvider.NewFromUtcNow(DateTime)"/> as the default.
        /// </summary>
        public static ConstructorValueUtcNowProvider New(DateTime utcNow)
        {
            var constantValueUtcNowProvider = ConstructorValueUtcNowProvider.NewFromUtcNow(utcNow);
            return constantValueUtcNowProvider;
        }

        public static ConstructorValueUtcNowProvider NewFromLocalNow(DateTime localNow)
        {
            var utcNow = localNow.ToUniversalTime();

            var constantValueUtcNowProvider = new ConstructorValueUtcNowProvider(utcNow);
            return constantValueUtcNowProvider;
        }

        public static ConstructorValueUtcNowProvider NewFromOffset(TimeSpan offset)
        {
            var offsetUtcNow = DateTime.UtcNow + offset;

            var constantValueUtcNowProvider = ConstructorValueUtcNowProvider.NewFromUtcNow(offsetUtcNow);
            return constantValueUtcNowProvider;
        }

        #endregion


        private DateTime UtcNow { get; }


        public ConstructorValueUtcNowProvider(DateTime utcNow)
        {
            this.UtcNow = utcNow;
        }

        public Task<DateTime> GetUtcNowAsync()
        {
            return Task.FromResult(this.UtcNow);
        }
    }
}
