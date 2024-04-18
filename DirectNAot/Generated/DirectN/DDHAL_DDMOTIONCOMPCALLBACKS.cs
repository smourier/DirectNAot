namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDMOTIONCOMPCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint GetMoCompGuids;
    public nint GetMoCompFormats;
    public nint CreateMoComp;
    public nint GetMoCompBuffInfo;
    public nint GetInternalMoCompInfo;
    public nint BeginMoCompFrame;
    public nint EndMoCompFrame;
    public nint RenderMoComp;
    public nint QueryMoCompStatus;
    public nint DestroyMoComp;
}
