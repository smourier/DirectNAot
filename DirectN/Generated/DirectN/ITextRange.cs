#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextrange
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cc497c2-a1df-11ce-8098-00aa0047be5d")]
public partial interface ITextRange : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-gettext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(out BSTR pbstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-settext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetText(BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getchar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChar(out int pChar);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setchar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChar(int Char);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getduplicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuplicate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange>))] out ITextRange ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getformattedtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormattedText([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange>))] out ITextRange ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setformattedtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormattedText([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange?>))] ITextRange? pRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStart(out int pcpFirst);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStart(int cpFirst);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnd(out int pcpLim);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnd(int cpLim);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFont([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont>))] out ITextFont ppFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFont([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont?>))] ITextFont? pFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getpara
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPara([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara>))] out ITextPara ppPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setpara
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPara([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextPara?>))] ITextPara? pPara);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getstorylength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStoryLength(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getstorytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStoryType(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-collapse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Collapse(int bStart);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-expand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Expand(int Unit, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndex(int Unit, out int pIndex);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndex(int Unit, int Index, int Extend);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRange(int cpAnchor, int cpActive);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-inrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InRange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange?>))] ITextRange? pRange, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-instory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InStory([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange?>))] ITextRange? pRange, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange?>))] ITextRange? pRange, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-select
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Select();
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-startof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartOf(int Unit, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-endof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndOf(int Unit, int Extend, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-move
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(int Unit, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-movestart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveStart(int Unit, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-moveend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveEnd(int Unit, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-movewhile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveWhile(in VARIANT Cset, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-movestartwhile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveStartWhile(in VARIANT Cset, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-moveendwhile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveEndWhile(in VARIANT Cset, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-moveuntil
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveUntil(in VARIANT Cset, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-movestartuntil
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveStartUntil(in VARIANT Cset, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-moveenduntil
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveEndUntil(in VARIANT Cset, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-findtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindText(BSTR bstr, int Count, tomConstants Flags, out int pLength);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-findtextstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTextStart(BSTR bstr, int Count, tomConstants Flags, out int pLength);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-findtextend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTextEnd(BSTR bstr, int Count, tomConstants Flags, out int pLength);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(int Unit, int Count, out int pDelta);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-cut
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cut(out VARIANT pVar);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-copy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Copy(out VARIANT pVar);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-paste
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Paste(in VARIANT pVar, int Format);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-canpaste
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanPaste(in VARIANT pVar, int Format, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-canedit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanEdit(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-changecase
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeCase(tomConstants Type);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPoint(tomConstants Type, out int px, out int py);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-setpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPoint(int x, int y, tomConstants Type, int Extend);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-scrollintoview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScrollIntoView(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextrange-getembeddedobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEmbeddedObject(out nint ppObject);
}
