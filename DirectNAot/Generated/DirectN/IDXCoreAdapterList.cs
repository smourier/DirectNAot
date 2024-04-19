namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/nn-dxcore_interface-idxcoreadapterlist
[GeneratedComInterface, Guid("526c7776-40e9-459b-b711-f32ad76dfc28")]
public partial interface IDXCoreAdapterList
{
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterlist-getadapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapter(uint index, in Guid riid, out nint ppvAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterlist-getadaptercount
    [PreserveSig]
    uint GetAdapterCount();
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterlist-isstale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsStale();
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterlist-getfactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFactory(in Guid riid, out nint ppvFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterlist-sort
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Sort(uint numPreferences, in DXCoreAdapterPreference preferences);
    
    // https://learn.microsoft.com/windows/win32/api/dxcore_interface/nf-dxcore_interface-idxcoreadapterlist-isadapterpreferencesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference);
}
