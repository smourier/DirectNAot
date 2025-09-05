namespace DirectN.Extensions.Utilities;

public class AcceleratorTable : IDisposable
{
    private HACCEL _handle;

    protected AcceleratorTable(HACCEL handle) => Initialize(handle);
    public AcceleratorTable(IEnumerable<ACCEL> accels)
    {
        ArgumentNullException.ThrowIfNull(accels);

        var accelArray = accels.ToArray();
        if (accelArray.Length < 1 || accelArray.Length > short.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(accels));

        var handle = Functions.CreateAcceleratorTableW(accelArray, accelArray.Length);
        if (handle == HACCEL.Null)
            throw new Win32Exception(Marshal.GetLastPInvokeError());

        Initialize(handle);
    }

    protected virtual void Initialize(HACCEL handle)
    {
        if (handle == HACCEL.Null)
            throw new ArgumentException(null, nameof(handle));

        _handle = handle;
        Count = Functions.CopyAcceleratorTableW(handle, 0, 0);
    }

    public HACCEL Handle => GetHandle();
    public int Count { get; protected set; }
    public bool IsDisposed => _handle == HACCEL.Null;

    protected HACCEL GetHandle()
    {
        var handle = _handle;
        return handle == HACCEL.Null ? throw new ObjectDisposedException(nameof(AcceleratorTable)) : handle;
    }

    public virtual int Translate(HWND hWnd, in MSG msg) => Functions.TranslateAcceleratorW(hWnd, Handle, msg);
    public virtual IReadOnlyList<ACCEL> Copy(int count)
    {
        var accels = new ACCEL[count];
        var copied = Functions.CopyAcceleratorTableW(Handle, accels.AsPointer(), accels.Length);
        return [.. accels.Take(copied)];
    }

    protected virtual void Dispose(bool disposing)
    {
        var handle = Interlocked.Exchange(ref _handle, HACCEL.Null);
        if (handle != HACCEL.Null)
        {
            Functions.DestroyAcceleratorTable(handle);
        }
    }

    ~AcceleratorTable() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    public static AcceleratorTable Load(HINSTANCE instance, string tableName) => Load(instance, PWSTR.From(tableName));
    public static AcceleratorTable Load(HINSTANCE instance, int resourceId) => Load(instance, new PWSTR(resourceId));
    public static AcceleratorTable Load(HINSTANCE instance, PWSTR tableName)
    {
        if (tableName.Value == 0)
            throw new ArgumentNullException(nameof(tableName));

        var handle = Functions.LoadAcceleratorsW(instance, tableName);
        if (handle == 0)
            throw new Win32Exception(Marshal.GetLastPInvokeError());

        return new AcceleratorTable(handle);
    }
}
