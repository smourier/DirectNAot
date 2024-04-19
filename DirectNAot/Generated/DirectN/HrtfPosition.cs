namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfposition
[StructLayout(LayoutKind.Sequential)]
public partial struct HrtfPosition
{
    public float x;
    public float y;
    public float z;
}
