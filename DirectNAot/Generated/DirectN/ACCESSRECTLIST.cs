namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACCESSRECTLIST
{
    public nint lpLink;
    public FoundationRECT rDest;
    public nint lpOwner;
    public nint lpSurfaceData;
    public uint dwFlags;
    public nint lpHeapAliasInfo;
}
