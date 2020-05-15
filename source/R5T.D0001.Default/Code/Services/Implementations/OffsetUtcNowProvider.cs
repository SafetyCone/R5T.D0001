using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class OffsetUtcNowProvider : IUtcNowProvider
    {
        #region Static

        public static OffsetUtcNowProvider NewFromOffset(TimeSpan offset)
        {
            var offsetUtcNowProvider = new OffsetUtcNowProvider(offset);
            return offsetUtcNowProvider;
        }

        public static OffsetUtcNowProvider New(TimeSpan offset)
        {
            var offsetUtcNowProvider = OffsetUtcNowProvider.NewFromOffset(offset);
            return offsetUtcNowProvider;
        }

        public static OffsetUtcNowProvider NewFromDesiredUtcNow(DateTime desiredUtcNow)
        {
            var offset = DateTime.UtcNow - desiredUtcNow;

            var offsetUtcNowProvider = OffsetUtcNowProvider.NewFromOffset(offset);
            return offsetUtcNowProvider;
        }

        public static OffsetUtcNowProvider NewFromDesiredLocalNow(DateTime desiredLocalNow)
        {
            var offset = DateTime.Now - desiredLocalNow;

            var offsetUtcNowProvider = OffsetUtcNowProvider.NewFromOffset(offset);
            return offsetUtcNowProvider;
        }

        #endregion


        private TimeSpan Offset { get; }


        public OffsetUtcNowProvider(TimeSpan offset)
        {
            this.Offset = offset;
        }

        public Task<DateTime> GetUtcNowAsync()
        {
            var utcNow = DateTime.UtcNow;

            var offsetUtcNow = utcNow + this.Offset;
            return Task.FromResult(offsetUtcNow);
        }
    }
}
