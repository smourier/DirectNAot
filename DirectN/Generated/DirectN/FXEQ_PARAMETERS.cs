#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapofx/ns-xapofx-fxeq_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct FXEQ_PARAMETERS
{
    public float FrequencyCenter0;
    public float Gain0;
    public float Bandwidth0;
    public float FrequencyCenter1;
    public float Gain1;
    public float Bandwidth1;
    public float FrequencyCenter2;
    public float Gain2;
    public float Bandwidth2;
    public float FrequencyCenter3;
    public float Gain3;
    public float Bandwidth3;
}
