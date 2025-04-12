namespace DirectN.Extensions.Utilities;

public class StorageMedium(STGMEDIUM medium) : IDisposable
{
    private STGMEDIUM _medium = medium;
    private bool _disposedValue;

    public STGMEDIUM STGMEDIUM => _medium;

    // stream is a copy, it lives its own live, independently from stg medium
    public virtual Stream? GetDetachedStream()
    {
        if (_medium.tymed == (uint)TYMED.TYMED_HGLOBAL)
        {
            using var stream = new LockedHGLOBALBuffer(_medium.u.hGlobal).GetUnmanagedMemoryStream();
            return stream.ToMemoryStream();
        }

        if (_medium.tymed == (uint)TYMED.TYMED_ISTREAM)
        {
            using var istream = ComObject.FromPointer<IStream>(_medium.u.pstm);
            if (istream == null)
                return null;

            using var strm = new StreamOnIStream(istream.Object);
            return strm.ToMemoryStream();
        }

        return null;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            Functions.ReleaseStgMedium(ref _medium);
            _medium.tymed = (uint)TYMED.TYMED_NULL;
            _disposedValue = true;
        }
    }

    ~StorageMedium() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
