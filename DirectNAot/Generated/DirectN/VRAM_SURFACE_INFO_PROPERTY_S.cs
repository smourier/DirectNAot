namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VRAM_SURFACE_INFO_PROPERTY_S
{
    public KSIDENTIFIER Property;
    public nint pVramSurfaceInfo;
}
