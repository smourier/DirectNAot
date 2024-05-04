#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_signalstatistics
[GeneratedComInterface, Guid("1347d106-cf3a-428a-a5cb-ac0d9a2a4338")]
public partial interface IBDA_SignalStatistics
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-put_signalstrength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalStrength(int lDbStrength);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-get_signalstrength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalStrength(ref int plDbStrength);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-put_signalquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalQuality(int lPercentQuality);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-get_signalquality
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalQuality(ref int plPercentQuality);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-put_signalpresent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalPresent(BOOLEAN fPresent);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-get_signalpresent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalPresent(nint /* byte array */ pfPresent);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-put_signallocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalLocked(BOOLEAN fLocked);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-get_signallocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalLocked(nint /* byte array */ pfLocked);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-put_sampletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SampleTime(int lmsSampleTime);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalstatistics-get_sampletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SampleTime(ref int plmsSampleTime);
}
