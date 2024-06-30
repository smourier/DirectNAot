#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dlight9
public partial struct D3DLIGHT9
{
    public D3DLIGHTTYPE Type;
    public D3DCOLORVALUE Diffuse;
    public D3DCOLORVALUE Specular;
    public D3DCOLORVALUE Ambient;
    public D3DVECTOR Position;
    public D3DVECTOR Direction;
    public float Range;
    public float Falloff;
    public float Attenuation0;
    public float Attenuation1;
    public float Attenuation2;
    public float Theta;
    public float Phi;
}
