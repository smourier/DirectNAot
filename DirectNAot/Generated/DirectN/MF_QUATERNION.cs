namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mf_quaternion
[StructLayout(LayoutKind.Sequential)]
public partial struct MF_QUATERNION
{
    public float x;
    public float y;
    public float z;
    public float w;
}
