#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/austream/nn-austream-iaudiodata
[GeneratedComInterface, Guid("54c719c0-af60-11d0-8212-00c04fc32c45")]
public partial interface IAudioData : IMemoryData
{
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-iaudiodata-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(out WAVEFORMATEX pWaveFormatCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-iaudiodata-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in WAVEFORMATEX lpWaveFormat);
}
