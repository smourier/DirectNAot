namespace DirectN;

[GeneratedComInterface, Guid("3c5f3e8a-90c0-464e-8136-898d2975f847")]
public partial interface IMFTimedTextBouten
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoutenType(out MF_TIMED_TEXT_BOUTEN_TYPE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoutenColor(out MFARGB value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoutenPosition(out MF_TIMED_TEXT_BOUTEN_POSITION value);
}
