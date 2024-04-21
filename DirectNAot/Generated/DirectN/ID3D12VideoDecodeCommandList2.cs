namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecodecommandlist2
[GeneratedComInterface, Guid("6e120880-c114-4153-8036-d247051e1729")]
public partial interface ID3D12VideoDecodeCommandList2 : ID3D12VideoDecodeCommandList1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist2-setprotectedresourcesession
    [PreserveSig]
    void SetProtectedResourceSession(ID3D12ProtectedResourceSession? pProtectedResourceSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist2-initializeextensioncommand
    [PreserveSig]
    void InitializeExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pInitializationParameters, nuint InitializationParametersSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecodecommandlist2-executeextensioncommand
    [PreserveSig]
    void ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pExecutionParameters, nuint ExecutionParametersSizeInBytes);
}
