#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportinputformatdata
public partial struct DD_GETVPORTINPUTFORMATDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpddpfFormat;
    public uint dwNumFormats;
    public HRESULT ddRVal;
    public nint GetVideoPortInputFormats;
}
