namespace DirectN.Extensions.Utilities;

public sealed partial class VerticalBlankTicker : IDisposable
{
    private volatile bool _stop;
    private volatile bool _throw = true;
    private Thread? _thread;
    private long _ticks;
    private int _tickDivider = 1;

    public event EventHandler<VerticalBlankTickerEventArgs>? Tick;
    public event EventHandler<VerticalBlankTickerErrorEventArgs>? WaitError;

    public string? DeviceName { get; private set; }
    public bool IsRunning { get; private set; }
    public bool ThrowExceptions { get => _throw; set => _throw = value; }
    public int TickDivider { get => _tickDivider; set => _tickDivider = value.Clamp(1); }

    public void EnsureStarted(string? deviceName = null, Action<Thread>? configure = null)
    {
        if (!IsRunning || (deviceName != null && !deviceName.EqualsIgnoreCase(DeviceName)))
        {
            Start(deviceName, configure);
        }
    }

    public void Dispose() => Stop();

    public bool? Stop(int? waitTimeout = null)
    {
        IsRunning = false;
        var oldThread = Interlocked.Exchange(ref _thread, null);
        if (oldThread != null && oldThread.IsAlive)
        {
            _stop = true;
            if (waitTimeout.HasValue)
                return oldThread.Join(waitTimeout.Value);

            return null;
        }
        return true;
    }

    public void Start(string? deviceName = null, Action<Thread>? configure = null)
    {
        Stop();
        IsRunning = true;
        _thread = new Thread(Wait)
        {
            IsBackground = true,
            Name = "_vbt_"
        };
        configure?.Invoke(_thread);
        _thread.Start(deviceName);
    }

    public void ResetTicks() => _ticks = 0;

    private void Wait(object? state)
    {
        var deviceName = ((string)state!).Nullify() ?? DisplayDevice.Primary?.DeviceName.Nullify();
        DeviceName = deviceName ?? @"\\.\DISPLAY1";

        var hdc = Functions.CreateDCW(PWSTR.Null, PWSTR.From(DeviceName), PWSTR.Null, 0);
        if (hdc.Value == 0)
        {
            IsRunning = false;
            throw new ExternalException();
        }

        var oa = new D3DKMT_OPENADAPTERFROMHDC
        {
            hDc = hdc
        };

        var status = D3DKMTOpenAdapterFromHdc(ref oa);
        Functions.DeleteDC(hdc);
        if (status < 0)
        {
            IsRunning = false;
            throw new Win32Exception(status);
        }

        var we = new D3DKMT_WAITFORVERTICALBLANKEVENT
        {
            hAdapter = oa.hAdapter,
            VidPnSourceId = oa.VidPnSourceId
        };

        var smallCount = 0;
        do
        {
            status = D3DKMTWaitForVerticalBlankEvent(we);
            if (status == 0)
            {
                if (_tickDivider > 1)
                {
                    smallCount++;
                    if (smallCount != _tickDivider)
                        continue;

                    smallCount = 0;
                }

                var e = new VerticalBlankTickerEventArgs(_ticks++);
                if (_throw)
                {
                    Tick?.Invoke(null, e);
                }
                else
                {
                    try
                    {
                        Tick?.Invoke(null, e);
                    }
                    catch
                    {
                        // continue
                    }
                }

                if (e.Cancel)
                {
                    Stop();
                }
            }
            else
            {
                var e = new VerticalBlankTickerErrorEventArgs(_ticks, status);
                WaitError?.Invoke(null, e);
                if (!e.Handled)
                {
                    IsRunning = false;
                    throw new Win32Exception(status);
                }
                else
                {
                    if (e.Stop)
                        break;
                }
            }

            if (_stop)
                break;
        }
        while (true);
        IsRunning = false;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DKMT_OPENADAPTERFROMHDC
    {
        public HDC hDc;
        public int hAdapter;
        public long AdapterLuid;
        public int VidPnSourceId;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct D3DKMT_WAITFORVERTICALBLANKEVENT
    {
        public int hAdapter;
        public int hDevice;
        public int VidPnSourceId;
    }

    [LibraryImport("gdi32")]
    private static partial int D3DKMTWaitForVerticalBlankEvent(in D3DKMT_WAITFORVERTICALBLANKEVENT arg);

    [LibraryImport("gdi32")]
    private static partial int D3DKMTOpenAdapterFromHdc(ref D3DKMT_OPENADAPTERFROMHDC arg);
}
