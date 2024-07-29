#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("eeb14b68-808b-4abe-a5ea-b51da7588008")]
public partial interface ISpeechMemoryStream : ISpeechBaseStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetData(VARIANT Data);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(out VARIANT pData);
}
