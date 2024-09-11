#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmlicensebackup
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("05e5ac9f-3fb6-4508-bb43-a4067ba1ebe8")]
public partial interface IWMLicenseBackup
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlicensebackup-backuplicenses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BackupLicenses(uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStatusCallback>))] IWMStatusCallback pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlicensebackup-cancellicensebackup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelLicenseBackup();
}
