namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSDS3D_HRTF_FILTER_FORMAT_MSG
{
    public KSDS3D_HRTF_FILTER_METHOD FilterMethod;
    public KSDS3D_HRTF_COEFF_FORMAT CoeffFormat;
    public KSDS3D_HRTF_FILTER_VERSION Version;
    public uint Reserved;
}
