#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b8be681a-eb2c-47f0-b415-94d5452f0e05")]
public partial interface IMSVidWebDVDAdm : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangePassword(BSTR strUserName, BSTR strOld, BSTR strNew);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveParentalLevel(int level, BSTR strUserName, BSTR strPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveParentalCountry(int country, BSTR strUserName, BSTR strPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfirmPassword(BSTR strUserName, BSTR strPassword, out VARIANT_BOOL pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentalLevel(out int lLevel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentalCountry(out int lCountry);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultAudioLCID(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultAudioLCID(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultSubpictureLCID(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultSubpictureLCID(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultMenuLCID(out int pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultMenuLCID(int newVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BookmarkOnStop(out VARIANT_BOOL pVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BookmarkOnStop(VARIANT_BOOL newVal);
}
