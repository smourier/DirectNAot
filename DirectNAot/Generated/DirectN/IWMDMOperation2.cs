namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmoperation2
[GeneratedComInterface, Guid("33445b48-7df7-425c-ad8f-0fc6d82f9f75")]
public partial interface IWMDMOperation2 : IWMDMOperation
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation2-setobjectattributes2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectAttributes2(uint dwAttributes, uint dwAttributesEx, nint/* nint */ pFormat, nint/* nint */ pVideoFormat);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmoperation2-getobjectattributes2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectAttributes2(out uint pdwAttributes, out uint pdwAttributesEx, nint/* nint */ pAudioFormat, nint/* nint */ pVideoFormat);
}
