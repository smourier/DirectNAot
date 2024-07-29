#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_isdbconditionalaccess
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5e68c627-16c2-4e6c-b1e2-d00170cdaa0f")]
public partial interface IBDA_ISDBConditionalAccess
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_isdbconditionalaccess-setisdbcasrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIsdbCasRequest(uint ulRequestId, uint ulcbRequestBufferLen, nint /* byte array */ pbRequestBuffer);
}
