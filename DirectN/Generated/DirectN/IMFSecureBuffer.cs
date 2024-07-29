#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c1209904-e584-4752-a2d6-7f21693f8b21")]
public partial interface IMFSecureBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIdentifier(out Guid pGuidIdentifier);
}
