namespace DirectN;

[GeneratedComInterface, Guid("5d1abfd6-450a-4d92-9efc-d6b6cbc1f4da")]
public partial interface IMFMediaSourceExtensionLiveSeekableRange
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLiveSeekableRange(double start, double end);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearLiveSeekableRange();
}
