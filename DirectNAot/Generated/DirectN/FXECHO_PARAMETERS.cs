namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapofx/ns-xapofx-fxecho_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct FXECHO_PARAMETERS
{
    public float WetDryMix;
    public float Feedback;
    public float Delay;
}
