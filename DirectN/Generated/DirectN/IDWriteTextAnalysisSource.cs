#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextanalysissource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("688e1a58-5094-47c8-adc8-fbcea60ae92b")]
public partial interface IDWriteTextAnalysisSource
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissource-gettextatposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextAtPosition(uint textPosition, out nint textString, out uint textLength);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissource-gettextbeforeposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextBeforePosition(uint textPosition, out nint textString, out uint textLength);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissource-getparagraphreadingdirection
    [PreserveSig]
    DWRITE_READING_DIRECTION GetParagraphReadingDirection();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissource-getlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleName(uint textPosition, out uint textLength, out nint localeName);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalysissource-getnumbersubstitution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberSubstitution(uint textPosition, out uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteNumberSubstitution>))] out IDWriteNumberSubstitution numberSubstitution);
}
