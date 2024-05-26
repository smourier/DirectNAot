namespace DirectN.Com
{
    public abstract class InterlockedComReference(nint reference) : IDisposable
    {
        private nint _reference = reference;

        public bool IsDisposed => _reference == 0;
        protected nint RawReference => _reference;
        public nint Reference
        {
            get
            {
                var reference = _reference;
                ObjectDisposedException.ThrowIf(reference == 0, this);
                return reference!;
            }
        }

        protected virtual nint ExchangeReference(nint reference)
        {
            // note there's no lock here
            var existing = _reference;
            if (existing != 0)
            {
                Marshal.Release(existing);
            }
            return Interlocked.Exchange(ref _reference, reference);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                var reference = Interlocked.Exchange(ref _reference, 0);
                if (reference != 0)
                {
                    Marshal.Release(reference);
                }
            }
        }

        ~InterlockedComReference() { Dispose(false); }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
    }
}
