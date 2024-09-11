#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextrow
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5ef-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextRow : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlignment(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlignment(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellCount(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellCount(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellcountcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellCountCache(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellcountcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellCountCache(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellIndex(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellIndex(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellmargin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellMargin(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellmargin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellMargin(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHeight(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHeight(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getindent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndent(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setindent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndent(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getkeeptogether
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeepTogether(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setkeeptogether
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeepTogether(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getkeepwithnext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeepWithNext(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setkeepwithnext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeepWithNext(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getnestlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNestLevel(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getrtl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRTL(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setrtl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRTL(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellAlignment(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellAlignment(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellcolorback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellColorBack(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellcolorback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellColorBack(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellcolorfore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellColorFore(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellcolorfore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellColorFore(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellmergeflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellMergeFlags(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellmergeflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellMergeFlags(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellshading
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellShading(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellshading
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellShading(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellverticaltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellVerticalText(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellverticaltext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellVerticalText(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellWidth(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellWidth(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellbordercolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellBorderColors(out int pcrLeft, out int pcrTop, out int pcrRight, out int pcrBottom);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getcellborderwidths
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCellBorderWidths(out int pduLeft, out int pduTop, out int pduRight, out int pduBottom);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellbordercolors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellBorderColors(int crLeft, int crTop, int crRight, int crBottom);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setcellborderwidths
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCellBorderWidths(int duLeft, int duTop, int duRight, int duBottom);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-apply
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Apply(int cRow, tomConstants Flags);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-canchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanChange(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(int Type, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-insert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Insert(int cRow);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRow?>))] ITextRow? pRow, out int pB);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrow-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(int Type, int Value);
}
