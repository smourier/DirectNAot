namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_library_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_LIBRARY_DESC
{
    public PSTR Creator;
    public uint Flags;
    public uint FunctionCount;
}
