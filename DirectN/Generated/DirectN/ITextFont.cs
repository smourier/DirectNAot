#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextfont
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cc497c3-a1df-11ce-8098-00aa0047be5d")]
public partial interface ITextFont : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getduplicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuplicate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont>))] out ITextFont ppFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setduplicate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuplicate(ITextFont? pFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-canchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanChange(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual(ITextFont? pFont, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(tomConstants Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStyle(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStyle(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getallcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllCaps(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setallcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllCaps(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAnimation(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAnimation(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getbackcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackColor(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setbackcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackColor(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getbold
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBold(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setbold
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBold(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getemboss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEmboss(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setemboss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEmboss(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getforecolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForeColor(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setforecolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetForeColor(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-gethidden
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHidden(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-sethidden
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHidden(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getengrave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEngrave(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setengrave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEngrave(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getitalic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItalic(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setitalic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetItalic(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getkerning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKerning(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setkerning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKerning(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getlanguageid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageID(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setlanguageid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLanguageID(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out BSTR pbstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetName(BSTR bstr);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getoutline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutline(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setoutline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutline(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getprotected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtected(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setprotected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProtected(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getshadow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShadow(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setshadow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShadow(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSize(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getsmallcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSmallCaps(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setsmallcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSmallCaps(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpacing(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSpacing(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getstrikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrikeThrough(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setstrikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrikeThrough(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getsubscript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubscript(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setsubscript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSubscript(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getsuperscript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSuperscript(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setsuperscript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSuperscript(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getunderline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnderline(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setunderline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnderline(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-getweight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWeight(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont-setweight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWeight(int Value);
}
