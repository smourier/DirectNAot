namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiomediatype/nn-audiomediatype-iaudiomediatype
[GeneratedComInterface, Guid("4e997f73-b71f-4798-873b-ed7dfcf15b4d")]
public partial interface IAudioMediaType
{
    // https://learn.microsoft.com/windows/win32/api/audiomediatype/nf-audiomediatype-iaudiomediatype-iscompressedformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsCompressedFormat([MarshalAs(UnmanagedType.U4)] out bool pfCompressed);
    
    // https://learn.microsoft.com/windows/win32/api/audiomediatype/nf-audiomediatype-iaudiomediatype-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual(IAudioMediaType pIAudioType, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/audiomediatype/nf-audiomediatype-iaudiomediatype-getaudioformat
    [PreserveSig]
    WAVEFORMATEX GetAudioFormat();
    
    // https://learn.microsoft.com/windows/win32/api/audiomediatype/nf-audiomediatype-iaudiomediatype-getuncompressedaudioformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUncompressedAudioFormat(out UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat);
}
