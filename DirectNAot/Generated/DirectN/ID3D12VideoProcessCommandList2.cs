namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoprocesscommandlist2
[GeneratedComInterface, Guid("db525ae4-6ad6-473c-baa7-59b2e37082e4")]
public partial interface ID3D12VideoProcessCommandList2 : ID3D12VideoProcessCommandList1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist2-setprotectedresourcesession
    [PreserveSig]
    void SetProtectedResourceSession(ID3D12ProtectedResourceSession pProtectedResourceSession);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist2-initializeextensioncommand
    [PreserveSig]
    void InitializeExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pInitializationParameters, nuint InitializationParametersSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist2-executeextensioncommand
    [PreserveSig]
    void ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pExecutionParameters, nuint ExecutionParametersSizeInBytes);
}
