namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoencodecommandlist1
[GeneratedComInterface, Guid("94971eca-2bdb-4769-88cf-3675ea757ebc")]
public partial interface ID3D12VideoEncodeCommandList1 : ID3D12VideoEncodeCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist1-initializeextensioncommand
    [PreserveSig]
    void InitializeExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pInitializationParameters, nuint InitializationParametersSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoencodecommandlist1-executeextensioncommand
    [PreserveSig]
    void ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, nint pExecutionParameters, nuint ExecutionParametersSizeInBytes);
}
