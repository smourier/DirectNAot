#nullable enable
namespace DirectN;

public partial struct D3DLIGHT7
{
    public D3DLIGHTTYPE dltType;
    public D3DCOLORVALUE dcvDiffuse;
    public D3DCOLORVALUE dcvSpecular;
    public D3DCOLORVALUE dcvAmbient;
    public D3DVECTOR dvPosition;
    public D3DVECTOR dvDirection;
    public float dvRange;
    public float dvFalloff;
    public float dvAttenuation0;
    public float dvAttenuation1;
    public float dvAttenuation2;
    public float dvTheta;
    public float dvPhi;
}
