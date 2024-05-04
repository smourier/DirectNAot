#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c3e4f353-433f-43d6-89a1-6a62a7054c3d")]
public partial interface ISpeechPhoneConverter : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LanguageId(out int LanguageId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LanguageId(int LanguageId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PhoneToId(BSTR Phonemes, out VARIANT IdArray);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IdToPhone(VARIANT IdArray, out BSTR Phonemes);
}
