#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DIRECTDRAW_LCL
{
    public uint lpDDMore;
    public nint lpGbl;
    public uint dwUnused0;
    public uint dwLocalFlags;
    public uint dwLocalRefCnt;
    public uint dwProcessId;
    public nint pUnkOuter;
    public uint dwObsolete1;
    public nuint hWnd;
    public nuint hDC;
    public uint dwErrorMode;
    public nint lpPrimary;
    public nint lpCB;
    public uint dwPreferredMode;
    public HINSTANCE hD3DInstance;
    public nint pD3DIUnknown;
    public nint lpDDCB;
    public nuint hDDVxd;
    public uint dwAppHackFlags;
    public nuint hFocusWnd;
    public uint dwHotTracking;
    public uint dwIMEState;
    public nuint hWndPopup;
    public nuint hDD;
    public nuint hGammaCalibrator;
    public nint lpGammaCalibrator;
}
