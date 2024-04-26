using System.Collections;

namespace DirectNAot.Extensions.Utilities
{
    public static class Extensions
    {
        public static DateTimeOffset ToDateTimeOffset(this FILETIME fileTime)
        {
            var ft = (((long)fileTime.dwHighDateTime) << 32) + fileTime.dwLowDateTime;
            return DateTimeOffset.FromFileTime(ft);
        }

        public static void Dispose(this IEnumerable disposables, bool throwOnError = false)
        {
            if (disposables == null)
                return;

            if (throwOnError)
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    disposable?.Dispose();
                }
            }
            else
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    try
                    {
                        disposable?.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }
    }
}
