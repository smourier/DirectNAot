namespace DirectN;

[GeneratedComInterface, Guid("ed32a372-f3c8-4faa-9cfb-470148da3888")]
public partial interface IDeferralCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke();
}
