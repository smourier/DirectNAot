namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetcurrentautoflipininfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETCURRENTAUTOFLIPININFO
{
    public nint lpVideoPortData;
}
