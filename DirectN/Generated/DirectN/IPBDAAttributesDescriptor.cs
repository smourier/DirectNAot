#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-ipbdaattributesdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("313b3620-3263-45a6-9533-968befbeac03")]
public partial interface IPBDAAttributesDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdaattributesdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdaattributesdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdaattributesdescriptor-getattributepayload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributePayload(out nint /* byte array */ ppbAttributeBuffer, out uint pdwAttributeLength);
}
