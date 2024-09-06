#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtextstyle
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("09b2455d-b834-4f01-a347-9052e21c450e")]
public partial interface IMFTimedTextStyle
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR name);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-isexternal
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsExternal();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getfontfamily
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFamily(out PWSTR fontFamily);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getfontsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontSize(out double fontSize, out MF_TIMED_TEXT_UNIT_TYPE unitType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColor(out MFARGB color);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(out MFARGB bgColor);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getshowbackgroundalways
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShowBackgroundAlways(out BOOL showBackgroundAlways);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getfontstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontStyle(out MF_TIMED_TEXT_FONT_STYLE fontStyle);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getbold
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBold(out BOOL bold);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-getrighttoleft
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRightToLeft(out BOOL rightToLeft);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-gettextalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextAlignment(out MF_TIMED_TEXT_ALIGNMENT textAlign);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-gettextdecoration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextDecoration(out uint textDecoration);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextstyle-gettextoutline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextOutline(out MFARGB color, out double thickness, out double blurRadius, out MF_TIMED_TEXT_UNIT_TYPE unitType);
}
