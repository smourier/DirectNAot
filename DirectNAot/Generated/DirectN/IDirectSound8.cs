#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c50a7e93-f395-4834-9ef6-7fa99de50966")]
public partial interface IDirectSound8 : IDirectSound
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VerifyCertification(out uint pdwCertified);
}
