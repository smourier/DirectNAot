#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdstate
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("86303d6d-1c4a-4087-ab42-f711167048ef")]
public partial interface IDvdState
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdstate-getdiscid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDiscID(out ulong pullUniqueID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdstate-getparentallevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentalLevel(out uint pulParentalLevel);
}
