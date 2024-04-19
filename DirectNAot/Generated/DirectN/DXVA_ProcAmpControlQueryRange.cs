namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_ProcAmpControlQueryRange
{
    public uint Size;
    public DXVA_ProcAmpControlProp ProcAmpControlProp;
    public DXVA_VideoDesc VideoDesc;
}
