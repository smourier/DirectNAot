#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/ns-mfcaptureengine-mfvideonormalizedrect
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoNormalizedRect
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}
