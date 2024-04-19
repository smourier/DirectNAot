namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-regfilterpins2
[StructLayout(LayoutKind.Sequential)]
public partial struct REGFILTERPINS2
{
    public uint dwFlags;
    public uint cInstances;
    public uint nMediaTypes;
    public nint lpMediaType;
    public uint nMediums;
    public nint lpMedium;
    public nint clsPinCategory;
}
