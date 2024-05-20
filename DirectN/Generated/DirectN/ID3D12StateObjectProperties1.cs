#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("460caac7-1d24-446a-a184-ca67db494138")]
public partial interface ID3D12StateObjectProperties1 : ID3D12StateObjectProperties
{
    [PreserveSig]
    D3D12_PROGRAM_IDENTIFIER GetProgramIdentifier(PWSTR pProgramName);
}
