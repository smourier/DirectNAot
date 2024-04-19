namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9procampcontrolrange
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9ProcAmpControlRange
{
    public uint dwSize;
    public VMR9ProcAmpControlFlags dwProperty;
    public float MinValue;
    public float MaxValue;
    public float DefaultValue;
    public float StepSize;
}
