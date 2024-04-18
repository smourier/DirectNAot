namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_parameter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_PARAMETER_DESC
{
    public PSTR Name;
    public PSTR SemanticName;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public D3D_SHADER_VARIABLE_CLASS Class;
    public uint Rows;
    public uint Columns;
    public D3D_INTERPOLATION_MODE InterpolationMode;
    public D3D_PARAMETER_FLAGS Flags;
    public uint FirstInRegister;
    public uint FirstInComponent;
    public uint FirstOutRegister;
    public uint FirstOutComponent;
}
