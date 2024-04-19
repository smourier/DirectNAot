namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtextformattedtext
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("e13af3c1-4d47-4354-b1f5-e83ae0ecae60")]
public partial interface IMFTimedTextFormattedText
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextformattedtext-gettext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(out PWSTR text);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextformattedtext-getsubformattingcount
    [PreserveSig]
    uint GetSubformattingCount();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextformattedtext-getsubformatting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubformatting(uint index, out uint firstChar, out uint charLength, out IMFTimedTextStyle style);
}
