using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class ConstructorValueNowUtcProvider : INowUtcProvider
    {
        #region Static

        public static ConstructorValueNowUtcProvider NewFromNowUtc(DateTime nowUtc)
        {
            var constantValueNowUtcProvider = new ConstructorValueNowUtcProvider(nowUtc);
            return constantValueNowUtcProvider;
        }

        /// <summary>
        /// Uses the <see cref="ConstructorValueNowUtcProvider.NewFromNowUtc(DateTime)"/> as the default.
        /// </summary>
        public static ConstructorValueNowUtcProvider New(DateTime nowUtc)
        {
            var constantValueNowUtcProvider = ConstructorValueNowUtcProvider.NewFromNowUtc(nowUtc);
            return constantValueNowUtcProvider;
        }

        public static ConstructorValueNowUtcProvider NewFromNowLocal(DateTime nowLocal)
        {
            var utcNow = nowLocal.ToUniversalTime();

            var constantValueNowUtcProvider = new ConstructorValueNowUtcProvider(utcNow);
            return constantValueNowUtcProvider;
        }

        public static ConstructorValueNowUtcProvider NewFromOffset(TimeSpan offset)
        {
            var offsetNowUtc = DateTime.UtcNow + offset;

            var constantValueNowUtcProvider = ConstructorValueNowUtcProvider.NewFromNowUtc(offsetNowUtc);
            return constantValueNowUtcProvider;
        }

        #endregion


        private DateTime NowUtc { get; }


        public ConstructorValueNowUtcProvider(DateTime nowUtc)
        {
            this.NowUtc = nowUtc;
        }

        public Task<DateTime> GetNowUtc()
        {
            return Task.FromResult(this.NowUtc);
        }
    }
}
