#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetcredential
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5b87ef6a-7ed8-434f-ba0e-184fac1628d1")]
public partial interface IMFNetCredential
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredential-setuser
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUser(nint /* byte array */ pbData, uint cbData, [MarshalAs(UnmanagedType.U4)] bool fDataIsEncrypted);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredential-setpassword
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPassword(nint /* byte array */ pbData, uint cbData, [MarshalAs(UnmanagedType.U4)] bool fDataIsEncrypted);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredential-getuser
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUser(nint /* optional byte* */ pbData, ref uint pcbData, [MarshalAs(UnmanagedType.U4)] bool fEncryptData);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredential-getpassword
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPassword(nint /* optional byte* */ pbData, ref uint pcbData, [MarshalAs(UnmanagedType.U4)] bool fEncryptData);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetcredential-loggedonuser
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoggedOnUser([MarshalAs(UnmanagedType.U4)] out bool pfLoggedOnUser);
}
