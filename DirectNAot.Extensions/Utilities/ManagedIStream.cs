namespace DirectNAot.Extensions.Utilities;

[ComVisible(true)]
[GeneratedComClass]
public sealed partial class ManagedIStream : IStream, IDisposable
{
    private Stream? _stream;
    private readonly bool _owned;

    public ManagedIStream(Stream stream, bool owned = false)
    {
        ArgumentNullException.ThrowIfNull(stream);
        _stream = stream;
        _owned = owned;
    }

    public ManagedIStream(string? text, Encoding? encoding = null)
        : this(GetStream(text, encoding), true)
    {
    }

    private static MemoryStream GetStream(string? text, Encoding? encoding)
    {
        if (!string.IsNullOrEmpty(text))
        {
            encoding ??= Encoding.Unicode;
            return new MemoryStream(encoding.GetBytes(text));
        }

        return new MemoryStream();
    }

    public void Dispose()
    {
        if (_owned)
        {
            Interlocked.Exchange(ref _stream, null)?.Dispose();
        }
    }

    private Stream CheckDisposed()
    {
        var stream = _stream;
        ObjectDisposedException.ThrowIf(stream == null, this);
        return stream;
    }

    HRESULT IStream.Seek(long dlibMove, STREAM_SEEK dwOrigin, nint plibNewPosition)
    {
        var newPos = CheckDisposed().Seek(dlibMove, (SeekOrigin)dwOrigin);
        if (plibNewPosition != 0)
        {
            Marshal.WriteInt64(plibNewPosition, newPos);
        }
        return Constants.S_OK;
    }

    HRESULT IStream.SetSize(ulong libNewSize)
    {
        CheckDisposed().SetLength((long)libNewSize);
        return Constants.S_OK;
    }

    HRESULT IStream.CopyTo(IStream pstm, ulong cb, nint pcbRead, nint pcbWritten)
    {
        ArgumentNullException.ThrowIfNull(pstm);

        long count;
        using (var stream = new StreamOnIStream(pstm))
        {
            count = CheckDisposed().CopyTo(stream, (long)cb);
        }

        if (pcbRead != 0)
        {
            Marshal.WriteInt64(pcbRead, count);
        }

        if (pcbWritten != 0)
        {
            Marshal.WriteInt64(pcbWritten, count);
        }
        return Constants.S_OK;
    }

    HRESULT IStream.Commit(uint grfCommitFlags)
    {
        _stream?.Flush(); // don't check if disposed
        return Constants.S_OK;
    }

    HRESULT IStream.Stat(out STATSTG pstatstg, uint grfStatFlag)
    {
        var stream = CheckDisposed();
        pstatstg = new STATSTG
        {
            type = (uint)STGTY.STGTY_STREAM,
            cbSize = (uint)stream.Length
        };

        if (stream.CanRead && stream.CanWrite)
        {
            pstatstg.grfMode |= STGM.STGM_READWRITE;
            return Constants.S_OK;
        }

        if (stream.CanRead)
        {
            pstatstg.grfMode |= STGM.STGM_READ;
            return Constants.S_OK;
        }

        if (stream.CanWrite)
        {
            pstatstg.grfMode |= STGM.STGM_WRITE;
            return Constants.S_OK;
        }

        throw new NotImplementedException();
    }

    HRESULT IStream.Clone(out IStream ppstm)
    {
        var clone = new ManagedIStream(CheckDisposed(), _owned);
        ppstm = clone;
        return Constants.S_OK;
    }

    HRESULT ISequentialStream.Read(nint pv, uint cb, nint pcbRead)
    {
        if (pv == 0)
            throw new ArgumentNullException(nameof(pv));

        var bytes = new byte[cb];
        var read = CheckDisposed().Read(bytes, 0, (int)cb);
        Marshal.Copy(bytes, 0, pv, read);
        if (pcbRead != 0)
        {
            Marshal.WriteInt32(pcbRead, read);
        }
        return Constants.S_OK;
    }

    HRESULT ISequentialStream.Write(nint pv, uint cb, nint pcbWritten)
    {
        if (pv == 0)
            throw new ArgumentNullException(nameof(pv));

        var bytes = new byte[cb];
        Marshal.Copy(pv, bytes, 0, (int)cb);
        CheckDisposed().Write(bytes, 0, (int)cb);
        if (pcbWritten != 0)
        {
            Marshal.WriteInt32(pcbWritten, (int)cb);
        }
        return Constants.S_OK;
    }

    HRESULT IStream.Revert() => throw new NotSupportedException();
    HRESULT IStream.LockRegion(ulong libOffset, ulong cb, uint dwLockType) => throw new NotSupportedException();
    HRESULT IStream.UnlockRegion(ulong libOffset, ulong cb, uint dwLockType) => throw new NotSupportedException();

}