#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmstreamprioritization
[GeneratedComInterface, Guid("8c1c6090-f9a8-4748-8ec3-dd1108ba1e77")]
public partial interface IWMStreamPrioritization
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamprioritization-getpriorityrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPriorityRecords([MarshalUsing(CountElementName = nameof(pcRecords))] out WM_STREAM_PRIORITY_RECORD[] pRecordArray, ref ushort pcRecords);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamprioritization-setpriorityrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPriorityRecords(in WM_STREAM_PRIORITY_RECORD pRecordArray, ushort cRecords);
}
