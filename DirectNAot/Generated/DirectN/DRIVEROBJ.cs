namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-driverobj
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVEROBJ
{
    public nint pvObj;
    public nint pFreeProc;
    public HDEV hdev;
    public DHPDEV dhpdev;
}
