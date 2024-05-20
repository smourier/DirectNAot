#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmlanguagelist
[GeneratedComInterface, Guid("df683f00-2d49-4d8e-92b7-fb19f6a0dc57")]
public partial interface IWMLanguageList
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlanguagelist-getlanguagecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageCount(out ushort pwCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlanguagelist-getlanguagedetails
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageDetails(ushort wIndex, [MarshalUsing(CountElementName = nameof(pcchLanguageStringLength))] out PWSTR pwszLanguageString, ref ushort pcchLanguageStringLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmlanguagelist-addlanguagebyrfc1766string
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddLanguageByRFC1766String(PWSTR pwszLanguageString, out ushort pwIndex);
}
