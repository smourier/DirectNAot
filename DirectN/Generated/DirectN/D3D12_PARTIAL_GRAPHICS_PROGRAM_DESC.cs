#nullable enable
namespace DirectN;

public partial struct D3D12_PARTIAL_GRAPHICS_PROGRAM_DESC
{
    public PWSTR ProgramName;
    public uint NumExports;
    public nint pExports;
    public uint NumSubobjects;
    public nint ppSubobjects;
    public D3D12_PARTIAL_GRAPHICS_PROGRAM_TYPE ProgramType;
}
