#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextrange2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5e2-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextRange2 : ITextSelection
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getcch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCch(out int pcch);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getcells
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCells(out nint ppCells);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getcolumn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumn(out nint ppColumn);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getduplicate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuplicate2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getfont2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFont2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont2>))] out ITextFont2 ppFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setfont2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFont2(ITextFont2? pFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getformattedtext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormattedText2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setformattedtext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormattedText2(ITextRange2? pRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getgravity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGravity(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setgravity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGravity(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getpara2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPara2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara2>))] out ITextPara2 ppPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setpara2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPara2(ITextPara2? pPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getrow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRow([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRow>))] out ITextRow ppRow);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getstartpara
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartPara(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-gettable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTable(out nint ppTable);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-geturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(out BSTR pbstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-seturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetURL(BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-addsubrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSubrange(int cp1, int cp2, int Activate);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-buildupmath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BuildUpMath(int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-deletesubrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteSubrange(int cpFirst, int cpLim);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-find
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Find(ITextRange2? pRange, int Count, int Flags, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getchar2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChar2(out int pChar, int Offset);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getdropcap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDropCap(out int pcLine, out int pPosition);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getinlineobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInlineObject(out int pType, out int pAlign, out int pChar, out int pChar1, out int pChar2, out int pCount, out int pTeXStyle, out int pcCol, out int pLevel);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(int Type, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRect(int Type, out int pLeft, out int pTop, out int pRight, out int pBottom, out int pHit);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getsubrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubrange(int iSubrange, out int pcpFirst, out int pcpLim);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-gettext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText2(int Flags, out BSTR pbstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-hextounicode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HexToUnicode();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-inserttable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertTable(int cCol, int cRow, int AutoFit);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-linearize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Linearize(int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setactivesubrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActiveSubrange(int cpAnchor, int cpActive);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setdropcap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDropCap(int cLine, int Position);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(int Type, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-settext2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetText2(int Flags, BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-unicodetohex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnicodeToHex();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-setinlineobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInlineObject(int Type, int Align, int Char, int Char1, int Char2, int Count, int TeXStyle, int cCol);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-getmathfunctiontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMathFunctionType(BSTR bstr, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange2-insertimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertImage(int width, int height, int ascent, int Type, BSTR bstrAltText, IStream? pStream);
}
