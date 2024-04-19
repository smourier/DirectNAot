namespace DirectN;

[GeneratedComInterface, Guid("b1a887b2-a4f0-407a-b02e-efbd23bbecdf")]
public partial interface IWMDRMTranscryptionManager
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmtranscryptionmanager-createtranscryptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTranscryptor(out IWMDRMTranscryptor ppTranscryptor);
}
