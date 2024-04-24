namespace DirectNAot.Extensions.Utilities
{
    public static class Extensions
    {
        public static DateTimeOffset ToDateTimeOffset(this FILETIME fileTime)
        {
            var ft = (((long)fileTime.dwHighDateTime) << 32) + fileTime.dwLowDateTime;
            return DateTimeOffset.FromFileTime(ft);
        }
    }
}
