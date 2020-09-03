using System;
using System.Threading.Tasks;


namespace R5T.D0001.Default
{
    public class OffsetNowUtcProvider : INowUtcProvider
    {
        #region Static

        public static OffsetNowUtcProvider NewFromOffset(TimeSpan offset)
        {
            var offsetNowUtcProvider = new OffsetNowUtcProvider(offset);
            return offsetNowUtcProvider;
        }

        public static OffsetNowUtcProvider New(TimeSpan offset)
        {
            var offsetNowUtcProvider = OffsetNowUtcProvider.NewFromOffset(offset);
            return offsetNowUtcProvider;
        }

        public static OffsetNowUtcProvider NewFromDesiredNowUtc(DateTime desiredNowUtc)
        {
            var offset = DateTime.UtcNow - desiredNowUtc;

            var offsetNowUtcProvider = OffsetNowUtcProvider.NewFromOffset(offset);
            return offsetNowUtcProvider;
        }

        public static OffsetNowUtcProvider NewFromDesiredNowLocal(DateTime desiredNowLocal)
        {
            var offset = DateTime.Now - desiredNowLocal;

            var offsetNowUtcProvider = OffsetNowUtcProvider.NewFromOffset(offset);
            return offsetNowUtcProvider;
        }

        #endregion


        private TimeSpan Offset { get; }


        public OffsetNowUtcProvider(TimeSpan offset)
        {
            this.Offset = offset;
        }

        public Task<DateTime> GetNowUtc()
        {
            var nowUtc = DateTime.UtcNow;

            var offsetNowUtc = nowUtc + this.Offset;
            return Task.FromResult(offsetNowUtc);
        }
    }
}
