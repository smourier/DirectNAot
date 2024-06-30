#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-facecharacterizationblobheader
public partial struct FaceCharacterizationBlobHeader
{
    public uint Size;
    public uint Count;
}
