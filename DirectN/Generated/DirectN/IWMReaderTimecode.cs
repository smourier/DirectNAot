#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreadertimecode
[GeneratedComInterface, Guid("f369e2f0-e081-4fe6-8450-b810b2f410d1")]
public partial interface IWMReaderTimecode
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadertimecode-gettimecoderangecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimecodeRangeCount(ushort wStreamNum, out ushort pwRangeCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadertimecode-gettimecoderangebounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimecodeRangeBounds(ushort wStreamNum, ushort wRangeNum, out uint pStartTimecode, out uint pEndTimecode);
}
