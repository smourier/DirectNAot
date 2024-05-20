#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspobjectinfo
[GeneratedComInterface, Guid("1dcb3a19-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IMDSPObjectInfo
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-getplaylength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayLength(out uint pdwLength);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-setplaylength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlayLength(uint dwLength);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-getplayoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayOffset(out uint pdwOffset);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-setplayoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlayOffset(uint dwOffset);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-gettotallength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalLength(out uint pdwLength);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-getlastplayposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastPlayPosition(out uint pdwLastPos);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobjectinfo-getlongestplayposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLongestPlayPosition(out uint pdwLongestPos);
}
