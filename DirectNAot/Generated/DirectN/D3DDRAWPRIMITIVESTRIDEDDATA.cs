namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDRAWPRIMITIVESTRIDEDDATA
{
    public D3DDP_PTRSTRIDE position;
    public D3DDP_PTRSTRIDE normal;
    public D3DDP_PTRSTRIDE diffuse;
    public D3DDP_PTRSTRIDE specular;
    public InlineArrayD3DDP_PTRSTRIDE8 textureCoords;
}
