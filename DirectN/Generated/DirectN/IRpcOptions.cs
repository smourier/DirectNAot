#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-irpcoptions
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000144-0000-0000-c000-000000000046")]
public partial interface IRpcOptions
{
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-irpcoptions-set
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Set(nint pPrx, RPCOPT_PROPERTIES dwProperty, nuint dwValue);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-irpcoptions-query
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Query(nint pPrx, RPCOPT_PROPERTIES dwProperty, out nuint pdwValue);
}
