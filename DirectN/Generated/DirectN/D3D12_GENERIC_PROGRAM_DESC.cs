#nullable enable
namespace DirectN;

public partial struct D3D12_GENERIC_PROGRAM_DESC
{
    public PWSTR ProgramName;
    public uint NumExports;
    public nint pExports;
    public uint NumSubobjects;
    public nint ppSubobjects;
}
