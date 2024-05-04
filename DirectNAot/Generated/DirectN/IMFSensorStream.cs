#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensorstream
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("e9a42171-c56e-498a-8b39-eda5a070b7fc")]
public partial interface IMFSensorStream : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorstream-getmediatypecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaTypeCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorstream-getmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaType(uint dwIndex, out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorstream-clonesensorstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloneSensorStream(out IMFSensorStream ppStream);
}
