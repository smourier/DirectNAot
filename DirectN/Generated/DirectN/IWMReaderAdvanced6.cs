#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderadvanced6
[GeneratedComInterface, Guid("18a2e7f8-428f-4acd-8a00-e64639bc93de")]
public partial interface IWMReaderAdvanced6 : IWMReaderAdvanced5
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced6-setprotectstreamsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProtectStreamSamples(nint /* byte array */ pbCertificate, uint cbCertificate, uint dwCertificateType, uint dwFlags, nint /* byte array */ pbInitializationVector, ref uint pcbInitializationVector);
}
