#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfmediakeystatus
public partial struct MFMediaKeyStatus
{
    public nint pbKeyId;
    public uint cbKeyId;
    public MF_MEDIAKEY_STATUS eMediaKeyStatus;
}
