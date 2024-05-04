#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspenumdevice
[GeneratedComInterface, Guid("1dcb3a11-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPEnumDevice
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumdevice-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [MarshalUsing(CountElementName = nameof(celt))] out IMDSPDevice[] ppDevice, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumdevice-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumdevice-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspenumdevice-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IMDSPEnumDevice ppEnumDevice);
}
