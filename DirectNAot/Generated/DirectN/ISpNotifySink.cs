namespace DirectN;

[GeneratedComInterface, Guid("259684dc-37c3-11d2-9603-00c04f8ee628")]
public partial interface ISpNotifySink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify();
}
