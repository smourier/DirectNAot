using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Utilities;

[GeneratedComClass]
public sealed partial class UnmanagedMemoryStream : Stream, IStream
{
    private IStream? _stream;
    private long _position;

    private UnmanagedMemoryStream(IStream stream, long position)
    {
        _stream = stream;
        _position = position;
    }

    public UnmanagedMemoryStream()
    {
        _stream = Functions.SHCreateMemStream(0, 0);
        CheckStream();
        Position = 0;
    }

    public UnmanagedMemoryStream(string filePath, STGM mode = STGM.STGM_READ)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        using var p = new Pwstr(filePath);
        Functions.SHCreateStreamOnFileW(p, (uint)mode, out _stream).ThrowOnError();
        Position = 0;
    }

    public UnmanagedMemoryStream(Stream stream, int bufferSize = 81920) // below LOH
        : this()
    {
        ArgumentNullException.ThrowIfNull(stream);
        ArgumentOutOfRangeException.ThrowIfLessThan(bufferSize, 1);
        stream.CopyTo(this, bufferSize);
        Position = 0;
    }

    public bool CommitOnDispose { get; set; } = true;
    public bool DeepClone { get; set; } = true;

    public UnmanagedMemoryStream(byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        _stream = Functions.SHCreateMemStream(bytes.AsPointer(), bytes.Length());
        CheckStream();
        Position = 0;
    }

    public UnmanagedMemoryStream(nint bytes, uint length)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        if (bytes == 0 && length > 0)
            throw new ArgumentOutOfRangeException(nameof(length));

        _stream = Functions.SHCreateMemStream(bytes, length);
        CheckStream();
        Position = 0;
    }

    public IStream NativeStream
    {
        get
        {
            var stream = _stream;
            ObjectDisposedException.ThrowIf(stream == null, this);
            return stream;
        }
    }

    public override long Length
    {
        get
        {
            NativeStream.Stat(out var stat, 0);
            return (long)stat.cbSize;
        }
    }

    public override int ReadTimeout => Timeout.Infinite;
    public override int WriteTimeout => Timeout.Infinite;
    public override bool CanTimeout => false;
    public override bool CanRead => true;
    public override bool CanSeek => true;
    public override bool CanWrite => true;

    public override long Position
    {
        get => _position;
        set
        {
            if (Position == value)
                return;

            Seek(value, SeekOrigin.Begin);
        }
    }

    public override void Flush() => ((IStream)this).Commit(0); // STGC_DEFAULT
    public override void SetLength(long value) => ((IStream)this).SetSize((ulong)value);
    public override long Seek(long offset, SeekOrigin origin)
    {
        ((IStream)this).Seek(offset, (STREAM_SEEK)origin, 0);
        return _position;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        ValidateBufferArguments(buffer, offset, count);
        unsafe
        {
            fixed (byte* p = buffer)
            {
                Read((nint)(p + offset), (uint)count, 0, out var read);
                return read;
            }
        }
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        ValidateBufferArguments(buffer, offset, count);
        unsafe
        {
            fixed (byte* p = buffer)
            {
                Write((nint)(p + offset), (uint)count, 0);
            }
        }
    }

    private void CheckStream()
    {
        if (_stream == null)
            throw new OutOfMemoryException();
    }

    protected override void Dispose(bool disposing)
    {
        var stream = Interlocked.Exchange(ref _stream, null);
        if (stream != null)
        {
            if (CommitOnDispose)
            {
                stream.Commit(0);
            }
            stream.FinalRelease();
        }
        base.Dispose(disposing);
    }

    unsafe HRESULT IStream.Seek(long dlibMove, STREAM_SEEK dwOrigin, nint plibNewPosition)
    {
        long newPos;
        if (plibNewPosition == 0)
        {
            plibNewPosition = (nint)(void*)&newPos;
        }

        var hr = NativeStream.Seek(dlibMove, dwOrigin, plibNewPosition);
        if (hr.IsError)
            return hr;

        _position = *(long*)plibNewPosition;
        return hr;
    }

    HRESULT ISequentialStream.Read(nint pv, uint cb, nint pcbRead) => Read(pv, cb, pcbRead, out _);
    unsafe private HRESULT Read(nint pv, uint cb, nint pcbRead, out int read)
    {
        int r;
        if (pcbRead == 0)
        {
            pcbRead = (nint)(void*)&r;
        }

        var hr = NativeStream.Read(pv, cb, pcbRead);
        if (hr.IsError)
        {
            read = 0;
            return hr;
        }

        read = *(int*)pcbRead;
        _position += read;
        return hr;
    }

    HRESULT ISequentialStream.Write(nint pv, uint cb, nint pcbWritten) => Write(pv, cb, pcbWritten);
    unsafe private HRESULT Write(nint pv, uint cb, nint pcbWritten)
    {
        int written;
        if (pcbWritten == 0)
        {
            pcbWritten = (nint)(void*)&written;
        }

        var hr = NativeStream.Write(pv, cb, pcbWritten);
        if (hr.IsError)
            return hr;

        written = *(int*)pcbWritten;
        _position += written;
        return hr;
    }

    HRESULT IStream.Clone(out IStream ppstm)
    {
        if (DeepClone)
        {
            var hr = NativeStream.Clone(out var clonedStream);
            if (hr.IsError)
            {
                ppstm = null!;
                return hr;
            }

            ppstm = new UnmanagedMemoryStream(clonedStream, _position);
            return hr;
        }

        return NativeStream.Clone(out ppstm);
    }

    HRESULT IStream.SetSize(ulong libNewSize) => NativeStream.SetSize(libNewSize);
    HRESULT IStream.CopyTo(IStream pstm, ulong cb, nint pcbRead, nint pcbWritten) => NativeStream.CopyTo(pstm, cb, pcbRead, pcbWritten);
    HRESULT IStream.Commit(uint grfCommitFlags) => NativeStream.Commit(grfCommitFlags);
    HRESULT IStream.Revert() => NativeStream.Revert();
    HRESULT IStream.LockRegion(ulong libOffset, ulong cb, uint dwLockType) => NativeStream.LockRegion(libOffset, cb, dwLockType);
    HRESULT IStream.UnlockRegion(ulong libOffset, ulong cb, uint dwLockType) => NativeStream.UnlockRegion(libOffset, cb, dwLockType);
    HRESULT IStream.Stat(out STATSTG pstatstg, uint grfStatFlag) => NativeStream.Stat(out pstatstg, grfStatFlag);
}
