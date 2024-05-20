#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/nn-d3dcommon-id3ddestructionotifier
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3")]
public partial interface ID3DDestructionNotifier
{
    // https://learn.microsoft.com/windows/win32/api/d3dcommon/nf-d3dcommon-id3ddestructionotifier-registerdestructioncallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterDestructionCallback(PFN_DESTRUCTION_CALLBACK callbackFn, nint pData, out uint pCallbackID);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcommon/nf-d3dcommon-id3ddestructionotifier-unregisterdestructioncallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterDestructionCallback(uint callbackID);
}
