#nullable enable
namespace DirectN;

public partial struct DDHAL_GETVPORTOUTPUTFORMATDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpddpfInputFormat;
    public nint lpddpfOutputFormats;
    public uint dwNumFormats;
    public HRESULT ddRVal;
    public nint GetVideoPortOutputFormats;
}
