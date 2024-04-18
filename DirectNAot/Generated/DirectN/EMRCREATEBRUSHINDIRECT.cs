namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcreatebrushindirect
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCREATEBRUSHINDIRECT
{
    public EMR emr;
    public uint ihBrush;
    public LOGBRUSH32 lb;
}
