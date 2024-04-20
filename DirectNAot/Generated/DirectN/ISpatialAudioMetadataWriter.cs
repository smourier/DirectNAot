namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudiometadatawriter
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("1b17ca01-2955-444d-a430-537dc589a844")]
public partial interface ISpatialAudioMetadataWriter
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatawriter-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(ISpatialAudioMetadataItems metadataItems);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatawriter-writenextitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteNextItem(ushort frameOffset);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatawriter-writenextitemcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteNextItemCommand(byte commandID, nint /* optional void */ valueBuffer, uint valueBufferLength);
    
    // https://learn.microsoft.com/windows/win32/CoreAudio/ispatialaudiometadatawriter-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
