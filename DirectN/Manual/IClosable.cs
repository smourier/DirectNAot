namespace DirectN;

[GeneratedComInterface, Guid("30d5a829-7fa4-4026-83bb-d75bae4ea99e")]
public partial interface IClosable : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
