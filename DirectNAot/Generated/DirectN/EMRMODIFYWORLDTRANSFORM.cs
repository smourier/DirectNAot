namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrmodifyworldtransform
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRMODIFYWORLDTRANSFORM
{
    public EMR emr;
    public XFORM xform;
    public MODIFY_WORLD_TRANSFORM_MODE iMode;
}
