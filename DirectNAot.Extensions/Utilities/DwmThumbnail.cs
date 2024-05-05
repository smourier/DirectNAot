namespace DirectNAot.Extensions.Utilities;

[SupportedOSPlatform("windows6.0.6000")]
public class DwmThumbnail : IDisposable
{
    private IntPtr _id;

    public DwmThumbnail(HWND hwndDestination, HWND hwndSource, bool throwOnError = true)
    {
        Functions.DwmRegisterThumbnail(hwndDestination, hwndSource, out _id).ThrowOnError(throwOnError);
    }

    public IntPtr Id => _id;
    public SIZE SourceSize
    {
        get
        {
            Functions.DwmQueryThumbnailSourceSize(CheckDisposed(), out var size);
            return size;
        }
    }

    public virtual HRESULT UpdateThumbnailProperties(DWM_THUMBNAIL_PROPERTIES properties, bool throwOnError = true) => Functions.DwmUpdateThumbnailProperties(CheckDisposed(), properties).ThrowOnError(throwOnError);

    public override string ToString() => Id.ToString();

    protected IntPtr CheckDisposed()
    {
        var id = Id;
        ObjectDisposedException.ThrowIf(id == 0, this);
        return id;
    }

    protected virtual void Dispose(bool disposing)
    {
        var id = Interlocked.Exchange(ref _id, IntPtr.Zero);
        if (id != IntPtr.Zero)
        {
            if (disposing)
            {
                // dispose managed state (managed objects)
            }

            // free unmanaged resources (unmanaged objects) and override finalizer
            // set large fields to null
            Functions.DwmUnregisterThumbnail(id);
        }
    }

    ~DwmThumbnail() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    public static bool IsCompositionEnabled { get => Functions.DwmIsCompositionEnabled(out var enabled).IsSuccess && enabled; set => Functions.DwmEnableComposition(value ? 1u : 0); }
}
