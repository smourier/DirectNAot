#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpclosedcaption2
[GeneratedComInterface, Guid("350ba78b-6bc8-4113-a5f5-312056934eb6")]
public partial interface IWMPClosedCaption2 : IWMPClosedCaption
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption2-get_samilangcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SAMILangCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption2-getsamilangname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getSAMILangName(int nIndex, out BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption2-getsamilangid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getSAMILangID(int nIndex, ref int plLangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption2-get_samistylecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SAMIStyleCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption2-getsamistylename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getSAMIStyleName(int nIndex, out BSTR pbstrName);
}
