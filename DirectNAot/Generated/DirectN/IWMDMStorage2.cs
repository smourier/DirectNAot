namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstorage2
[GeneratedComInterface, Guid("1ed5a144-5cd5-4683-9eff-72cbdb2d9533")]
public partial interface IWMDMStorage2 : IWMDMStorage
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage2-getstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorage(PWSTR pszStorageName, out IWMDMStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage2-setattributes2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttributes2(uint dwAttributes, uint dwAttributesEx, nint /* optional WAVEFORMATEX* */ pFormat, nint /* optional VIDEOINFOHEADER* */ pVideoFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage2-getattributes2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributes2(out uint pdwAttributes, out uint pdwAttributesEx, nint /* optional WAVEFORMATEX* */ pAudioFormat, nint /* optional VIDEOINFOHEADER* */ pVideoFormat);
}
