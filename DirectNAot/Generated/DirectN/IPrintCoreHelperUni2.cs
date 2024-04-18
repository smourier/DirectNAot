namespace DirectN;

[GeneratedComInterface, Guid("6c8afdfc-ead0-4d2d-8071-9bf0175a6c3a")]
public partial interface IPrintCoreHelperUni2 : IPrintCoreHelperUni
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNamedCommand(nint/* nint */ pDevmode, uint cbSize, PWSTR pszCommandName, out nint /* byte array */ ppCommandBytes, out uint pcbCommandSize);
}
