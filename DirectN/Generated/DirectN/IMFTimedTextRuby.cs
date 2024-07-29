#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("76c6a6f5-4955-4de5-b27b-14b734cc14b4")]
public partial interface IMFTimedTextRuby
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRubyText(out PWSTR rubyText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRubyPosition(out MF_TIMED_TEXT_RUBY_POSITION value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRubyAlign(out MF_TIMED_TEXT_RUBY_ALIGN value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRubyReserve(out MF_TIMED_TEXT_RUBY_RESERVE value);
}
