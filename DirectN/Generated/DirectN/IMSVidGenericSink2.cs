#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidgenericsink2
[GeneratedComInterface, Guid("6b5a28f3-47f1-4092-b168-60cabec08f1c")]
public partial interface IMSVidGenericSink2 : IMSVidGenericSink
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgenericsink2-addfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFilter(BSTR bstrName);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidgenericsink2-resetfilterlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetFilterList();
}
