#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbcabledeliverysystemdescriptor
[GeneratedComInterface, Guid("dfb98e36-9e1a-4862-9946-993a4e59017b")]
public partial interface IDvbCableDeliverySystemDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-getfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrequency(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-getfecouter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFECOuter(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-getmodulation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModulation(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-getsymbolrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSymbolRate(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbcabledeliverysystemdescriptor-getfecinner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFECInner(nint /* byte array */ pbVal);
}
