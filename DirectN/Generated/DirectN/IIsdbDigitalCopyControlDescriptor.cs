#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbdigitalcopycontroldescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1a28417e-266a-4bb8-a4bd-d782bcfb8161")]
public partial interface IIsdbDigitalCopyControlDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdigitalcopycontroldescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdigitalcopycontroldescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdigitalcopycontroldescriptor-getcopycontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCopyControl(nint /* byte array */ pbDigitalRecordingControlData, nint /* byte array */ pbCopyControlType, nint /* byte array */ pbAPSControlData, nint /* byte array */ pbMaximumBitrate);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdigitalcopycontroldescriptor-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdigitalcopycontroldescriptor-getrecordcopycontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCopyControl(byte bRecordIndex, nint /* byte array */ pbComponentTag, nint /* byte array */ pbDigitalRecordingControlData, nint /* byte array */ pbCopyControlType, nint /* byte array */ pbAPSControlData, nint /* byte array */ pbMaximumBitrate);
}
