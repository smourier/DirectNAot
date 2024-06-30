#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dmaterial9
public partial struct D3DMATERIAL9
{
    public D3DCOLORVALUE Diffuse;
    public D3DCOLORVALUE Ambient;
    public D3DCOLORVALUE Specular;
    public D3DCOLORVALUE Emissive;
    public float Power;
}
