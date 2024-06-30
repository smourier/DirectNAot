#nullable enable
namespace DirectN;

public partial struct CDDDXGK_REDIRBITMAPPRESENTINFO
{
    public uint NumDirtyRects;
    public nint DirtyRect;
    public uint NumContexts;
    public InlineArrayHANDLE_65 hContext;
    public BOOLEAN bDoNotSynchronizeWithDxContent;
}
