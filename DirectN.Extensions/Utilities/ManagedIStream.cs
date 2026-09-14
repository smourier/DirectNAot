using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Utilities;
[ComVisible(true)]
[GeneratedComClass]
public sealed partial class ManagedIStream : IStream, IDisposable
{
    private const int _copyBufferSize = 81920;
    private SharedStream? _state;
    private long _position;
    private bool _independentPosition;
    public ManagedIStream(Stream stream, bool owned = false)
    {
        ArgumentNullException.ThrowIfNull(stream);
        _state = new SharedStream(stream, owned);
    }

    private ManagedIStream(SharedStream state, long position)
    {
        _state = state;
        _position = position;
        _independentPosition = true;
        state.References++;
    }

    public ManagedIStream(string? text, Encoding? encoding = null) : this(string.IsNullOrEmpty(text) ? new MemoryStream() : new MemoryStream((encoding ?? Encoding.Unicode).GetBytes(text)), true)
    {
    }

    private sealed class SharedStream(Stream stream, bool owned)
    {
        public Stream Stream { get; } = stream;
        public bool Owned { get; } = owned;

        public int References = 1;
    }

    private SharedStream _currentState => _state ?? throw new ObjectDisposedException(nameof(ManagedIStream));

    private Stream GetStream(SharedStream state)
    {
        ObjectDisposedException.ThrowIf(_state == null, this);
        if (_independentPosition)
        {
            state.Stream.Position = _position;
        }

        return state.Stream;
    }

    public void Dispose()
    {
        if (_state is { Owned: false })
            return;

        Release();
        GC.SuppressFinalize(this);
    }

    private void Release()
    {
        var state = _state;
        if (state == null)
            return;

        lock (state)
        {
            if (Interlocked.Exchange(ref _state, null) == null)
                return;

            if (--state.References == 0 && state.Owned)
            {
                state.Stream.Dispose();
            }
        }
    }

    ~ManagedIStream()
    {
        try
        {
            Release();
        }
        catch
        {
        }
    }

    HRESULT IStream.Seek(long dlibMove, STREAM_SEEK dwOrigin, nint plibNewPosition)
    {
        var state = _currentState;
        lock (state)
        {
            _position = GetStream(state).Seek(dlibMove, (SeekOrigin)dwOrigin);
            if (plibNewPosition != 0)
            {
                Marshal.WriteInt64(plibNewPosition, _position);
            }
        }

        return Constants.S_OK;
    }

    HRESULT IStream.SetSize(ulong libNewSize)
    {
        var state = _currentState;
        lock (state)
        {
            GetStream(state).SetLength(checked((long)libNewSize));
        }

        return Constants.S_OK;
    }

    unsafe HRESULT IStream.CopyTo(IStream pstm, ulong cb, nint pcbRead, nint pcbWritten)
    {
        ArgumentNullException.ThrowIfNull(pstm);
        ulong totalRead = 0;
        ulong totalWritten = 0;
        var bytes = new byte[(int)Math.Min(cb, (ulong)_copyBufferSize)];
        try
        {
            fixed (byte* pointer = bytes)
            {
                while (totalRead < cb)
                {
                    var count = (uint)Math.Min((ulong)bytes.Length, cb - totalRead);
                    uint read = 0;
                    var hr = ((IStream)this).Read((nint)pointer, count, (nint)(&read));
                    if (hr.IsError)
                        return hr;

                    totalRead += read;
                    if (read > 0)
                    {
                        uint written = 0;
                        hr = pstm.Write((nint)pointer, read, (nint)(&written));
                        totalWritten += written;
                        if (hr.IsError)
                            return hr;

                        if (written != read)
                            return Constants.STG_E_WRITEFAULT;
                    }

                    if (read < count)
                        return Constants.S_FALSE;
                }
            }

            return Constants.S_OK;
        }
        finally
        {
            if (pcbRead != 0)
            {
                Marshal.WriteInt64(pcbRead, (long)totalRead);
            }

            if (pcbWritten != 0)
            {
                Marshal.WriteInt64(pcbWritten, (long)totalWritten);
            }
        }
    }

    HRESULT IStream.Commit(uint grfCommitFlags)
    {
        var state = _state;
        if (state != null)
        {
            lock (state)
            {
                if (_state != null)
                {
                    state.Stream.Flush();
                }
            }
        }

        return Constants.S_OK;
    }

    HRESULT IStream.Stat(out STATSTG pstatstg, uint grfStatFlag)
    {
        var state = _currentState;
        lock (state)
        {
            var stream = GetStream(state);
            pstatstg = new STATSTG
            {
                type = (uint)STGTY.STGTY_STREAM,
                cbSize = checked((ulong)stream.Length),
                grfMode = stream.CanWrite ? stream.CanRead ? STGM.STGM_READWRITE : STGM.STGM_WRITE : STGM.STGM_READ
            };
        }

        return Constants.S_OK;
    }

    HRESULT IStream.Clone(out IStream ppstm)
    {
        var state = _currentState;
        lock (state)
        {
            var stream = GetStream(state);
            if (!stream.CanSeek)
            {
                ppstm = null!;
                return Constants.E_NOTIMPL;
            }

            _position = stream.Position;
            _independentPosition = true;
            ppstm = new ManagedIStream(state, _position);
        }

        return Constants.S_OK;
    }

    unsafe HRESULT ISequentialStream.Read(nint pv, uint cb, nint pcbRead)
    {
        if (pv == 0 && cb != 0)
            throw new ArgumentNullException(nameof(pv));

        var state = _currentState;
        int read;
        lock (state)
        {
            var stream = GetStream(state);
            read = stream.ReadAtLeast(new Span<byte>((void*)pv, checked((int)cb)), checked((int)cb), false);
            if (_independentPosition)
            {
                _position = stream.Position;
            }
        }

        if (pcbRead != 0)
        {
            Marshal.WriteInt32(pcbRead, read);
        }

        return read == cb ? Constants.S_OK : Constants.S_FALSE;
    }

    unsafe HRESULT ISequentialStream.Write(nint pv, uint cb, nint pcbWritten)
    {
        if (pv == 0 && cb != 0)
            throw new ArgumentNullException(nameof(pv));

        var state = _currentState;
        lock (state)
        {
            var stream = GetStream(state);
            stream.Write(new ReadOnlySpan<byte>((void*)pv, checked((int)cb)));
            if (_independentPosition)
            {
                _position = stream.Position;
            }
        }

        if (pcbWritten != 0)
        {
            Marshal.WriteInt32(pcbWritten, checked((int)cb));
        }

        return Constants.S_OK;
    }

    HRESULT IStream.Revert() => throw new NotSupportedException();
    HRESULT IStream.LockRegion(ulong libOffset, ulong cb, uint dwLockType) => throw new NotSupportedException();
    HRESULT IStream.UnlockRegion(ulong libOffset, ulong cb, uint dwLockType) => throw new NotSupportedException();
}
