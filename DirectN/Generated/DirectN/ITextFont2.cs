#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextfont2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5e3-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextFont2 : ITextFont
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out int pCount);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getautoligatures
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutoLigatures(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setautoligatures
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutoLigatures(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getautospacealpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutospaceAlpha(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setautospacealpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutospaceAlpha(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getautospacenumeric
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutospaceNumeric(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setautospacenumeric
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutospaceNumeric(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getautospaceparens
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutospaceParens(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setautospaceparens
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutospaceParens(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getcharrep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCharRep(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setcharrep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCharRep(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getcompressionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompressionMode(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setcompressionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCompressionMode(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getcookie
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCookie(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setcookie
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCookie(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getdoublestrike
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDoubleStrike(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setdoublestrike
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDoubleStrike(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getduplicate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuplicate2([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextFont2>))] out ITextFont2 ppFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setduplicate2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuplicate2(ITextFont2? pFont);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getlinktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLinkType(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getmathzone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMathZone(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setmathzone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMathZone(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getmodwidthpairs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModWidthPairs(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setmodwidthpairs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetModWidthPairs(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getmodwidthspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModWidthSpace(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setmodwidthspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetModWidthSpace(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getoldnumbers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOldNumbers(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setoldnumbers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOldNumbers(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getoverlapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlapping(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setoverlapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOverlapping(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getpositionsubsuper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPositionSubSuper(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setpositionsubsuper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPositionSubSuper(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getscaling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScaling(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setscaling
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScaling(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getspaceextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpaceExtension(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setspaceextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSpaceExtension(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getunderlinepositionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnderlinePositionMode(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setunderlinepositionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnderlinePositionMode(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-geteffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffects(out int pValue, out int pMask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-geteffects2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffects2(out int pValue, out int pMask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(int Type, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-getpropertyinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyInfo(int Index, out int pType, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-isequal2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual2(ITextFont2? pFont, out int pB);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-seteffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffects(int Value, int Mask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-seteffects2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffects2(int Value, int Mask);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextfont2-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(int Type, int Value);
}
