namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_feature_data_doubles
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_FEATURE_DATA_DOUBLES
{
    [MarshalAs(UnmanagedType.U4)]
    public bool doublePrecisionFloatShaderOps;
}
