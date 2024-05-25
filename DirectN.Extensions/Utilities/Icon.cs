namespace DirectN.Utilities
{
    public class Icon : IDisposable
    {
        private nint _handle;

        public HICON Handle => new() { Value = _handle };

        public static Icon? ExtractAssociatedIcon(string iconPath)
        {
            ArgumentNullException.ThrowIfNull(iconPath);
            ushort icon = 0;
            var handle = Functions.ExtractAssociatedIconW(HINSTANCE.Null, PWSTR.From(iconPath), ref icon).Value;
            if (handle == 0)
                return null;

            return new Icon { _handle = handle };
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                var handle = Interlocked.Exchange(ref _handle, 0);
                if (handle != 0)
                {
                    Functions.DestroyIcon(new HICON { Value = handle });
                }
            }
        }

        ~Icon() { Dispose(disposing: false); }
        public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    }
}
