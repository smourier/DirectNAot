namespace DirectN;

[GeneratedComInterface, Guid("db639199-c809-4c89-bfca-d0bbb9729d6e")]
public partial interface IMFTimedTextStyle2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuby(out IMFTimedTextRuby ruby);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBouten(out IMFTimedTextBouten bouten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTextCombined([MarshalAs(UnmanagedType.U4)] out bool value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontAngleInDegrees(out double value);
}
