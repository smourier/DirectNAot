#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f4711347-e608-11d2-a086-00c04f8ef9b5")]
public partial interface ISpErrorLog
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddError(int lLineNumber, HRESULT hr, PWSTR pszDescription, PWSTR pszHelpFile, uint dwHelpContext);
}
