namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetpreviousautoflipininfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETPREVIOUSAUTOFLIPININFO
{
    public nint lpVideoPortData;
}
