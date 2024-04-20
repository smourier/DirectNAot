namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nn-spatialaudiometadata-ispatialaudioobjectformetadatacommands
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("0df2c94b-f5f9-472d-af6b-c46e0ac9cd05")]
public partial interface ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectBase
{
    // https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/nf-spatialaudiometadata-ispatialaudioobjectformetadatacommands-writenextmetadatacommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteNextMetadataCommand(byte commandID, nint /* optional void */ valueBuffer, uint valueBufferLength);
}
