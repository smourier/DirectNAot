#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("56a868ff-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IAMPlayListItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceCount(out uint pdwSources);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceURL(uint dwSourceIndex, out BSTR pbstrURL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceStart(uint dwSourceIndex, out long prtStart);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceDuration(uint dwSourceIndex, out long prtDuration);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceStartMarker(uint dwSourceIndex, out uint pdwMarker);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceEndMarker(uint dwSourceIndex, out uint pdwMarker);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceStartMarkerName(uint dwSourceIndex, out BSTR pbstrStartMarker);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceEndMarkerName(uint dwSourceIndex, out BSTR pbstrEndMarker);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLinkURL(out BSTR pbstrURL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScanDuration(uint dwSourceIndex, out long prtScanDuration);
}
