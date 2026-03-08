namespace DirectN.Extensions.Utilities;

// note this must not be released too early or DWrite will crash silently when trying to load the font file stream
[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class PackedFontFileLoader : IDWriteFontFileLoader, IDisposable
{
    private bool _disposedValue;

    public PackedFontFileLoader(IComObject<IDWriteFactory5> factory, DWRITE_CONTAINER_TYPE containerType)
    {
        ArgumentNullException.ThrowIfNull(factory);
        if (containerType == DWRITE_CONTAINER_TYPE.DWRITE_CONTAINER_TYPE_UNKNOWN)
            throw new ArgumentException(null, nameof(containerType));

        Factory = factory;
        ContainerType = containerType;
        Factory.Object.RegisterFontFileLoader(this);
    }

    public IComObject<IDWriteFactory5> Factory { get; }
    public DWRITE_CONTAINER_TYPE ContainerType { get; }
    public bool IsDisposed => _disposedValue;

    public virtual HRESULT CreateStreamFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, out IDWriteFontFileStream fontFileStream)
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        return Factory.Object.UnpackFontFile(ContainerType, fontFileReferenceKey, fontFileReferenceKeySize, out fontFileStream);
    }

    [SupportedOSPlatform("windows6.1")]
    public virtual IComObject<IDWriteFontFile> CreateCustomFontFileReference(string filePath)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        var bytes = File.ReadAllBytes(filePath);
        unsafe
        {
            fixed (byte* ptr = bytes)
            {
                return Factory.Object.CreateCustomFontFileReference((nint)ptr, (uint)bytes.Length, this);
            }
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            Factory.Object.UnregisterFontFileLoader(this);
            _disposedValue = true;
        }
    }

    ~PackedFontFileLoader() { Dispose(disposing: false); }
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
