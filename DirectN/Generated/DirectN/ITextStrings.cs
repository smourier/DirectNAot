#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextstrings
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5e7-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextStrings : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append(ITextRange2? pRange, int iString);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-cat2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cat2(int iString);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-cattop2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CatTop2(BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-deleterange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteRange(ITextRange2? pRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-encodefunction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EncodeFunction(int Type, int Align, int Char, int Char1, int Char2, int Count, int TeXStyle, int cCol, ITextRange2? pRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-getcch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCch(int iString, out int pcch);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-insertnullstr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertNullStr(int iString);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-moveboundary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveBoundary(int iString, int cch);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-prefixtop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrefixTop(BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(int iString, int cString);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-setformattedtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormattedText(ITextRange2? pRangeD, ITextRange2? pRangeS);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-setopcp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpCp(int iString, int cp);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-suffixtop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SuffixTop(BSTR bstr, ITextRange2? pRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstrings-swap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Swap();
}
