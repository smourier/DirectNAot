#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/unknwn/nn-unknwn-iclassfactory
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000001-0000-0000-c000-000000000046")]
public partial interface IClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/unknwn/nf-unknwn-iclassfactory-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(nint pUnkOuter, in Guid riid, out nint /* void */ ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/unknwn/nf-unknwn-iclassfactory-lockserver
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockServer([MarshalAs(UnmanagedType.U4)] bool fLock);
}
