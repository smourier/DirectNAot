#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a655fb94-0589-4e57-b333-567a89468c88")]
public partial interface IDirectDrawVideoPortNotify
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireNotification(ref HANDLE param0, ref DDVIDEOPORTNOTIFY param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseNotification(HANDLE param0);
}
