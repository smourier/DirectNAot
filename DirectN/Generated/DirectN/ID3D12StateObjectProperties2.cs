#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d5e82917-f0f1-44cf-ae5e-ce222dd0b884")]
public partial interface ID3D12StateObjectProperties2 : ID3D12StateObjectProperties1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlobalRootSignatureForProgram(PWSTR pProgramName, in Guid riid, out nint /* void */ ppvRootSignature);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlobalRootSignatureForShader(PWSTR pExportName, in Guid riid, out nint /* void */ ppvRootSignature);
}
