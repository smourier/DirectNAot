#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8445c581-0cac-4a38-abfe-9b2ce2826455")]
public partial interface ISpPhoneConverter : ISpObjectWithToken
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PhoneToId(PWSTR pszPhone, out ushort pId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IdToPhone(in ushort pId, out PWSTR pszPhone);
}
