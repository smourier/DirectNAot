#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7a3bac98-0e76-49fb-8c20-8a86fd98eaf2")]
public partial interface IMFMediaEngineAudioEndpointId
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioEndpointId(PWSTR? pszEndpointId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioEndpointId(out PWSTR ppszEndpointId);
}
