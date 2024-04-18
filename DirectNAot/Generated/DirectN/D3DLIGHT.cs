namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DLIGHT
{
    public uint dwSize;
    public D3DLIGHTTYPE dltType;
    public D3DCOLORVALUE dcvColor;
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
