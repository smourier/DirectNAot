namespace DirectNAot.Extensions.Utilities;

public class StreamOnIStream(IStream stream, bool releaseOnDispose = false) : Stream
{
    private const int STATFLAG_NONAME = 1;
    private IStream? _stream = stream;
    private nint _ptr = Marshal.AllocCoTaskMem(8);
    private long _position;

    public IStream NativeStream => CheckDisposed();
    public bool ReleaseOnDispose { get; } = releaseOnDispose;
    public override bool CanTimeout => false;
    public override int ReadTimeout => Timeout.Infinite;
    public override int WriteTimeout => Timeout.Infinite;
    public override bool CanRead { get; } = true;
    public override bool CanSeek { get; } = true;
    public override bool CanWrite { get; } = true;
    public override long Position { get => _position; set => Seek(value, SeekOrigin.Begin); }
    public override long Length
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return (long)stat.cbSize;
        }
    }

    public DateTimeOffset LastWriteTime
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return stat.mtime.ToDateTimeOffset();
        }
    }

    public DateTimeOffset LastAccessTime
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return stat.atime.ToDateTimeOffset();
        }
    }

    public Guid Clsid
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return stat.clsid;
        }
    }

    public string? Name
    {
        get
        {
            CheckDisposed().Stat(out var stat, 0);
            if (stat.pwcsName.Value != 0)
            {
                var str = stat.pwcsName.ToString();
                Marshal.FreeCoTaskMem(stat.pwcsName.Value);
                return str;
            }
            return null;
        }
    }

    public DateTimeOffset CreationTime
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return stat.ctime.ToDateTimeOffset();
        }
    }

    public STGM StorageMode
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return stat.grfMode;
        }
    }

    public STGTY StorageType
    {
        get
        {
            CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
            return (STGTY)stat.type;
        }
    }

    public virtual void Flush(STGC options) => CheckDisposed().Commit((uint)options);
    public override void Flush() => Flush(STGC.STGC_DEFAULT);
    public override int Read(byte[] buffer, int offset, int count)
    {
        ValidateBufferArguments(buffer, offset, count);
        if (count == 0)
            return 0;

        int read;
        unsafe
        {
            fixed (byte* p = buffer)
            {
                CheckDisposed().Read((nint)(p + offset), (uint)count, _ptr).ThrowOnError();
            }

            read = *(int*)_ptr;
        }

        _position += read;
        return read;
    }

    public override void SetLength(long value) => CheckDisposed().SetSize((ulong)value);
    public override long Seek(long offset, SeekOrigin origin)
    {
        CheckDisposed().Seek(offset, (STREAM_SEEK)origin, _ptr).ThrowOnError();
        unsafe
        {
            _position = *(long*)_ptr;
        }
        return _position;
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        ValidateBufferArguments(buffer, offset, count);
        if (count == 0)
            return;

        int written;
        unsafe
        {
            fixed (byte* p = buffer)
            {
                CheckDisposed().Write((nint)(p + offset), (uint)count, _ptr).ThrowOnError();
            }
            written = *(int*)_ptr;
        }

        _position += written;
    }

    private IStream CheckDisposed()
    {
        var stream = _stream;
        ObjectDisposedException.ThrowIf(stream == null, this);
        return stream;
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        var stream = Interlocked.Exchange(ref _stream, null);
        if (stream != null)
        {
            try
            {
                stream.Commit((int)STGC.STGC_DEFAULT);
                if (ReleaseOnDispose)
                {
                    stream.FinalRelease();
                }
            }
            catch
            {
                // do nothing
            }
        }

        var ptr = Interlocked.Exchange(ref _ptr, 0);
        if (ptr != 0)
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }
}
