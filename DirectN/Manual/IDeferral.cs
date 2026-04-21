namespace DirectN;

[GeneratedComInterface, Guid("d6269732-3b7f-46a7-b40b-4fdca2a2c693")]
public partial interface IDeferral : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Complete();
}
