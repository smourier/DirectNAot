namespace DirectN;

[GeneratedComInterface, Guid("68C6A1B9-DE39-42C3-8D28-BF40A5126541")]
public partial interface ICallingProcessInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenCallerProcessHandle(PROCESS_ACCESS_RIGHTS desiredAccess, out HANDLE handle);
}
