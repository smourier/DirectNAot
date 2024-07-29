#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderstreamclock
[GeneratedComInterface, Guid("96406bed-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMReaderStreamClock
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderstreamclock-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(in ulong pcnsNow);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderstreamclock-settimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimer(ulong cnsWhen, nint pvParam, out uint pdwTimerId);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderstreamclock-killtimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KillTimer(uint dwTimerId);
}
