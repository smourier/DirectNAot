namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritetextlayout1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9064d822-80a7-465c-a986-df65f78b8feb")]
public partial interface IDWriteTextLayout1 : IDWriteTextLayout
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-setpairkerning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPairKerning([MarshalAs(UnmanagedType.U4)] bool isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-getpairkerning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPairKerning(uint currentPosition, [MarshalAs(UnmanagedType.U4)] out bool isPairKerningEnabled, nint/* nint */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-setcharacterspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextlayout1-getcharacterspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCharacterSpacing(uint currentPosition, out float leadingSpacing, out float trailingSpacing, out float minimumAdvanceWidth, nint/* nint */ textRange);
}
