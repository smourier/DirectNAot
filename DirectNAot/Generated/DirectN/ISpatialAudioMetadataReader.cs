namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudiometadatareader
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("b78e86a2-31d9-4c32-94d2-7df40fc7ebec")]
public partial interface ISpatialAudioMetadataReader
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatareader-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(ISpatialAudioMetadataItems metadataItems);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatareader-readnextitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadNextItem(nint /* byte array */ commandCount, out ushort frameOffset);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatareader-readnextitemcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadNextItemCommand(nint /* byte array */ commandID, nint valueBuffer, uint maxValueBufferLength, out uint valueBufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudiometadatareader-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
