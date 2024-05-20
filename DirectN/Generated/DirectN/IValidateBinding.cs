#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("04a578b2-e778-422a-a805-b3ee54d90bd9")]
public partial interface IValidateBinding
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIdentifier(Guid guidLicensorID, nint /* byte array */ pbEphemeron, uint cbEphemeron, out nint /* byte array */ ppbBlobValidationID, out uint pcbBlobSize);
}
