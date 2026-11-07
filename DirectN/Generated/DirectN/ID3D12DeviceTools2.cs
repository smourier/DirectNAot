#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0edb4324-20a7-45ed-8016-c317a073be33")]
public partial interface ID3D12DeviceTools2 : ID3D12DeviceTools1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserDefinedAnnotationMode(D3D12_USER_DEFINED_ANNOTATION_MODE mode);
    
    [PreserveSig]
    D3D12_USER_DEFINED_ANNOTATION_MODE GetUserDefinedAnnotationMode();
}
