#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreadercallback
[GeneratedComInterface, Guid("96406bd8-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMReaderCallback : IWMStatusCallback
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallback-onsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSample(uint dwOutputNum, ulong cnsSampleTime, ulong cnsSampleDuration, uint dwFlags, INSSBuffer pSample, nint pvContext);
}
