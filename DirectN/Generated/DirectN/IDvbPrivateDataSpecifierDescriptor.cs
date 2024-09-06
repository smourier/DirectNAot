#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbprivatedataspecifierdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5660a019-e75a-4b82-9b4c-ed2256d165a2")]
public partial interface IDvbPrivateDataSpecifierDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbprivatedataspecifierdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbprivatedataspecifierdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbprivatedataspecifierdescriptor-getprivatedataspecifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateDataSpecifier(out uint pdwVal);
}
