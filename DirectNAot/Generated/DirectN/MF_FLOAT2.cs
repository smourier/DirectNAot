namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mf_float2
[StructLayout(LayoutKind.Sequential)]
public partial struct MF_FLOAT2
{
    public float x;
    public float y;
}
