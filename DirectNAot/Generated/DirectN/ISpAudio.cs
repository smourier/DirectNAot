namespace DirectN;

[GeneratedComInterface, Guid("c05c768f-fae8-4ec2-8e07-338321c12452")]
public partial interface ISpAudio : ISpStreamFormat
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(SPAUDIOSTATE NewState, ulong ullReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in Guid rguidFmtId, in WAVEFORMATEX pWaveFormatEx);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(ref SPAUDIOSTATUS pStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferInfo(in SPAUDIOBUFFERINFO pBuffInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferInfo(ref SPAUDIOBUFFERINFO pBuffInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultFormat(ref Guid pFormatId, ref WAVEFORMATEX ppCoMemWaveFormatEx);
    
    [PreserveSig]
    HANDLE EventHandle();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolumeLevel(ref uint pLevel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVolumeLevel(uint Level);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferNotifySize(ref uint pcbSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferNotifySize(uint cbSize);
}
