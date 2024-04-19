namespace DirectN;

[GeneratedComInterface, Guid("cee3def2-3808-414d-be66-fafd472210bc")]
public partial interface IWMValidate
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIdentifier(Guid guidValidationID);
}
