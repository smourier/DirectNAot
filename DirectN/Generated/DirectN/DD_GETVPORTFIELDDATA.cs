#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportfielddata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETVPORTFIELDDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public BOOL bField;
    public HRESULT ddRVal;
    public nint GetVideoPortField;
}
