#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7a1ef0d5-1581-4741-88e4-209a49f11a10")]
public partial interface ISpeechWaveFormatEx : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FormatTag(out short FormatTag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FormatTag(short FormatTag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Channels(out short Channels);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Channels(short Channels);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SamplesPerSec(out int SamplesPerSec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SamplesPerSec(int SamplesPerSec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvgBytesPerSec(out int AvgBytesPerSec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AvgBytesPerSec(int AvgBytesPerSec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BlockAlign(out short BlockAlign);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BlockAlign(short BlockAlign);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BitsPerSample(out short BitsPerSample);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BitsPerSample(short BitsPerSample);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ExtraData(out VARIANT ExtraData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ExtraData(VARIANT ExtraData);
}
