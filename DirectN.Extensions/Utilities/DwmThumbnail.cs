namespace DirectN.Extensions.Utilities;

public class DwmThumbnail : IDisposable
{
    private nint _id;

    public DwmThumbnail(HWND hwndDestination, HWND hwndSource, bool throwOnError = true)
    {
        Functions.DwmRegisterThumbnail(hwndDestination, hwndSource, out _id).ThrowOnError(throwOnError);
    }

    public nint Id => _id;
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

    protected nint CheckDisposed()
    {
        var id = Id;
        ObjectDisposedException.ThrowIf(id == 0, this);
        return id;
    }

    protected virtual void Dispose(bool disposing)
    {
        var id = Interlocked.Exchange(ref _id, nint.Zero);
        if (id != 0)
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
