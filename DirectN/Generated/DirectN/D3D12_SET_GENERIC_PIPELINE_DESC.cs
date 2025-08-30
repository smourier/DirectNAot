#nullable enable
namespace DirectN;

public partial struct D3D12_SET_GENERIC_PIPELINE_DESC : IValueGet<D3D12_PROGRAM_IDENTIFIER>
{
    public D3D12_PROGRAM_IDENTIFIER ProgramIdentifier;
    
    readonly D3D12_PROGRAM_IDENTIFIER IValueGet<D3D12_PROGRAM_IDENTIFIER>.GetValue() => ProgramIdentifier;
    readonly object? IValueGet.GetValue() => ProgramIdentifier;
}
