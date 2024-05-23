#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-itocparser
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ecfb9a55-9298-4f49-887f-0b36206599d2")]
public partial interface ITocParser
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(PWSTR pwszFileName);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-gettoccount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTocCount(TOC_POS_TYPE enumTocPosType, ref uint pdwTocCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-gettocbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTocByIndex(TOC_POS_TYPE enumTocPosType, uint dwTocIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IToc>))] out IToc ppToc);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-gettocbytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTocByType(TOC_POS_TYPE enumTocPosType, Guid guidTocType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITocCollection>))] out ITocCollection ppTocs);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-addtoc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddToc(TOC_POS_TYPE enumTocPosType, IToc pToc, ref uint pdwTocIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-removetocbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveTocByIndex(TOC_POS_TYPE enumTocPosType, uint dwTocIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-removetocbytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveTocByType(TOC_POS_TYPE enumTocPosType, Guid guidTocType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-itocparser-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
}
