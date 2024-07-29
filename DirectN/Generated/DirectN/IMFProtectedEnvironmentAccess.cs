#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfprotectedenvironmentaccess
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("ef5dc845-f0d9-4ec9-b00c-cb5183d38434")]
public partial interface IMFProtectedEnvironmentAccess
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfprotectedenvironmentaccess-call
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Call(uint inputLength, nint /* byte array */ input, uint outputLength, nint /* byte array */ output);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfprotectedenvironmentaccess-readgrl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadGRL(out uint outputLength, out nint /* byte array */ output);
}
