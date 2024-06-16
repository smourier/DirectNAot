#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("db639199-c809-4c89-bfca-d0bbb9729d6e")]
public partial interface IMFTimedTextStyle2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuby([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextRuby>))] out IMFTimedTextRuby ruby);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBouten([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextBouten>))] out IMFTimedTextBouten bouten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTextCombined(out BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAngleInDegrees(out double value);
}
