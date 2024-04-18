namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_input_layout_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_INPUT_LAYOUT_DESC
{
    public nint pInputElementDescs;
    public uint NumElements;
}
