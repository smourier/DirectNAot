#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspstorage2
[GeneratedComInterface, Guid("0a5e07a5-6454-4451-9c36-1c6ae7e2b1d6")]
public partial interface IMDSPStorage2 : IMDSPStorage
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage2-getstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorage(PWSTR pszStorageName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPStorage>))] out IMDSPStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage2-createstorage2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStorage2(uint dwAttributes, uint dwAttributesEx, nint /* optional WAVEFORMATEX* */ pAudioFormat, nint /* optional VIDEOINFOHEADER* */ pVideoFormat, PWSTR pwszName, ulong qwFileSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPStorage>))] out IMDSPStorage ppNewStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage2-setattributes2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributes2(uint dwAttributes, uint dwAttributesEx, nint /* optional WAVEFORMATEX* */ pAudioFormat, nint /* optional VIDEOINFOHEADER* */ pVideoFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage2-getattributes2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes2(out uint pdwAttributes, out uint pdwAttributesEx, nint /* optional WAVEFORMATEX* */ pAudioFormat, nint /* optional VIDEOINFOHEADER* */ pVideoFormat);
}
