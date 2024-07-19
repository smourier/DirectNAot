using System.Runtime.InteropServices.Marshalling;

namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.1")]
[GeneratedComClass]
public partial class DWriteFontCollectionLoader : IDWriteFontCollectionLoader, IDisposable
{
    private bool _disposedValue = false;
    private readonly FontFileLoader _loader = new();

    public DWriteFontCollectionLoader()
    {
        using var fac = DWriteFunctions.DWriteCreateFactory();
        fac.Object.RegisterFontCollectionLoader(this).ThrowOnError();
        fac.Object.RegisterFontFileLoader(_loader).ThrowOnError();
    }

    public virtual Func<IDWriteFactory, byte[]?, IEnumerable<DWriteFontFile>>? EnumerableFunc { get; set; }

    HRESULT IDWriteFontCollectionLoader.CreateEnumeratorFromKey(IDWriteFactory factory, nint collectionKey, uint collectionKeySize, out IDWriteFontFileEnumerator fontFileEnumerator)
    {
        var func = EnumerableFunc;
        if (func == null)
        {
            fontFileEnumerator = null!;
            ComError.SetError(nameof(EnumerableFunc) + " was not set.");
            return Constants.DISP_E_EXCEPTION;
        }

        byte[]? key;
        if (collectionKey == 0 || collectionKeySize == 0)
        {
            key = null;
        }
        else
        {
            key = new byte[collectionKeySize];
            Marshal.Copy(collectionKey, key, 0, (int)collectionKeySize);
        }

        var enumerable = func(factory, key);
        if (enumerable == null)
        {
            fontFileEnumerator = null!;
            ComError.SetError(nameof(EnumerableFunc) + " returned nothing.");
            return Constants.DISP_E_EXCEPTION;
        }

        var enumerator = enumerable.GetEnumerator();
        if (enumerator == null)
        {
            fontFileEnumerator = null!;
            ComError.SetError(nameof(EnumerableFunc) + " returned a null enumerator.");
            return Constants.DISP_E_EXCEPTION;
        }

        fontFileEnumerator = new FontFileEnumerator(factory, _loader, enumerator);
        return Constants.S_OK;
    }

    [GeneratedComClass]
    private partial class FontFileEnumerator(IDWriteFactory factory, FontFileLoader loader, IEnumerator<DWriteFontFile> enumerator) : IDWriteFontFileEnumerator
    {
        private readonly IDWriteFactory _factory = factory;
        private readonly IEnumerator<DWriteFontFile> _enumerator = enumerator;
        private readonly FontFileLoader _loader = loader;

        public HRESULT GetCurrentFontFile(out IDWriteFontFile fontFile)
        {
            DWriteFontFile file;
            try
            {
                file = _enumerator.Current;
            }
            catch (Exception e)
            {
                ComError.SetError(e.GetAllMessages());
                fontFile = null!;
                return Constants.DISP_E_EXCEPTION;
            }

            if (file is DWriteFontStreamFile sf && sf.FilePath != null)
            {
                var ft = sf.LastWriteTime?.ToFileTime();
                return _factory.CreateFontFileReference(PWSTR.From(sf.FilePath), ft.CopyToPointer(), out fontFile);
            }

            var stream = new FontFileStream(file);
            _loader.AddStream(stream);
            return _factory.CreateCustomFontFileReference(stream.Key, stream.KeySize, _loader, out fontFile);
        }

        public HRESULT MoveNext(out BOOL hasCurrentFile)
        {
            try
            {
                hasCurrentFile = _enumerator.MoveNext();
                return Constants.S_OK;
            }
            catch (Exception e)
            {
                ComError.SetError(e.GetAllMessages());
                hasCurrentFile = false;
                return Constants.DISP_E_EXCEPTION;
            }
        }
    }

    [GeneratedComClass]
    private partial class FontFileLoader : IDWriteFontFileLoader, IDisposable
    {
        private readonly ConcurrentDictionary<int, FontFileStream> _streams = new();
        private int _index;

        public void AddStream(FontFileStream stream)
        {
            _streams[_index] = stream;
            Marshal.WriteInt32(stream.Key, _index);
            _index++;
        }

        public void Dispose()
        {
            foreach (var stream in _streams)
            {
                stream.Value.Dispose();
            }
        }

        HRESULT IDWriteFontFileLoader.CreateStreamFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, out IDWriteFontFileStream fontFileStream)
        {
            if (fontFileReferenceKeySize == 4)
            {
                var index = Marshal.ReadInt32(fontFileReferenceKey);
                _streams.TryGetValue(index, out var stream);
                if (stream != null)
                {
                    fontFileStream = stream;
                    return Constants.S_OK;
                }
            }

            fontFileStream = null!;
            return Constants.E_UNEXPECTED;
        }
    }

    [GeneratedComClass]
    private partial class FontFileStream : IDWriteFontFileStream, IDisposable
    {
        private readonly DWriteFontFile _file;
        private nint _key;

        public FontFileStream(DWriteFontFile file)
        {
            _file = file;
            KeySize = 4;
            _key = Marshal.AllocCoTaskMem((int)KeySize);
        }

        public nint Key => _key;
        public uint KeySize { get; }

        public void Dispose()
        {
            ((IDisposable)_file)?.Dispose();
            var key = Interlocked.Exchange(ref _key, 0);
            if (key != 0)
            {
                Marshal.FreeCoTaskMem(key);
            }
        }

        HRESULT IDWriteFontFileStream.GetFileSize(out ulong fileSize)
        {
            if (_file.Length.HasValue)
            {
                fileSize = (ulong)_file.Length.Value;
                return Constants.S_OK;
            }

            fileSize = 0;
            return Constants.E_NOTIMPL;
        }

        HRESULT IDWriteFontFileStream.GetLastWriteTime(out ulong lastWriteTime)
        {
            if (_file.LastWriteTime.HasValue)
            {
                lastWriteTime = (ulong)_file.LastWriteTime.Value.ToFileTime();
                return Constants.S_OK;
            }

            lastWriteTime = 0;
            return Constants.E_NOTIMPL;
        }

        HRESULT IDWriteFontFileStream.ReadFileFragment(out nint fragmentStart, ulong fileOffset, ulong fragmentSize, out nint fragmentContext)
        {
            fragmentStart = 0;
            fragmentContext = 0;
            var bytes = _file.ReadFileFragment((long)fileOffset, (int)fragmentSize, out var read);
            if (bytes == null || bytes.Length == 0 || read == 0)
                return Constants.E_FAIL;

            if (read < 0 || read > bytes.Length)
            {
                ComError.SetError("Invalid ReadFileFragment implementation.");
                return Constants.DISP_E_EXCEPTION;
            }

            fragmentContext = Marshal.AllocHGlobal(read);
            fragmentStart = fragmentContext;
            Marshal.Copy(bytes, 0, fragmentContext, read);
            return Constants.S_OK;
        }

        void IDWriteFontFileStream.ReleaseFileFragment(nint fragmentContext) => Marshal.FreeHGlobal(fragmentContext);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // dispose managed state (managed objects).
            }

            // free unmanaged resources (unmanaged objects) and override a finalizer below.
            // set large fields to null.

            using (var fac = DWriteFunctions.DWriteCreateFactory())
            {
                fac.Object.UnregisterFontFileLoader(_loader).ThrowOnError();
                fac.Object.UnregisterFontCollectionLoader(this).ThrowOnError();
            }

            _loader.Dispose();
            _disposedValue = true;
        }
    }

    ~DWriteFontCollectionLoader() { Dispose(false); }
    public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
}
