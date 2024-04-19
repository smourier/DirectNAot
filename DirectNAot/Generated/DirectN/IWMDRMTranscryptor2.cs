namespace DirectN;

[GeneratedComInterface, Guid("e0da439f-d331-496a-bece-18e5bac5dd23")]
public partial interface IWMDRMTranscryptor2 : IWMDRMTranscryptor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SeekEx(ulong cnsStartTime, ulong cnsDuration, float flRate, [MarshalAs(UnmanagedType.U4)] bool fIncludeFileHeader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ZeroAdjustTimestamps([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSeekStartTime(out ulong pcnsTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuration(out ulong pcnsDuration);
}
