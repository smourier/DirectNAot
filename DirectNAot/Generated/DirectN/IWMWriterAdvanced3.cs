namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriteradvanced3
[GeneratedComInterface, Guid("2cd6492d-7c37-4e76-9d3b-59261183a22e")]
public partial interface IWMWriterAdvanced3 : IWMWriterAdvanced2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced3-getstatisticsex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatisticsEx(ushort wStreamNum, out WM_WRITER_STATISTICS_EX pStats);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced3-setnonblocking
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNonBlocking();
}
