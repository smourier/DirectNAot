namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetpolarityininfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETPOLARITYININFO
{
    public nint lpVideoPortData;
}
