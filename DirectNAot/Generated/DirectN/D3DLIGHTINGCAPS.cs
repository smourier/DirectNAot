namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DLIGHTINGCAPS
{
    public uint dwSize;
    public uint dwCaps;
    public uint dwLightingModel;
    public uint dwNumLights;
}
