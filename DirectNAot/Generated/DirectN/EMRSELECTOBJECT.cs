namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrselectobject
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSELECTOBJECT
{
    public EMR emr;
    public uint ihObject;
}
