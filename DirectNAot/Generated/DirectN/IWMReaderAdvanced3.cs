namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderadvanced3
[GeneratedComInterface, Guid("5dc0674b-f04b-4a4e-9f2a-b1afde2c8100")]
public partial interface IWMReaderAdvanced3 : IWMReaderAdvanced2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced3-stopnetstreaming
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopNetStreaming();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced3-startatposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartAtPosition(ushort wStreamNum, nint pvOffsetStart, nint pvDuration, WMT_OFFSET_FORMAT dwOffsetFormat, float fRate, nint pvContext);
}
