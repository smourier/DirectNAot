#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritecolorglyphrunenumerator
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d31fbe17-f157-41a2-8d24-cb779e0560e8")]
public partial interface IDWriteColorGlyphRunEnumerator
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritecolorglyphrunenumerator-movenext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext(out BOOL hasRun);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritecolorglyphrunenumerator-getcurrentrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentRun(out nint colorGlyphRun);
}
