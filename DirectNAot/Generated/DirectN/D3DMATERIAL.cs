namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DMATERIAL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public D3DCOLORVALUE diffuse;
        
        [FieldOffset(0)]
        public D3DCOLORVALUE dcvDiffuse;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public D3DCOLORVALUE ambient;
        
        [FieldOffset(0)]
        public D3DCOLORVALUE dcvAmbient;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public D3DCOLORVALUE specular;
        
        [FieldOffset(0)]
        public D3DCOLORVALUE dcvSpecular;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public D3DCOLORVALUE emissive;
        
        [FieldOffset(0)]
        public D3DCOLORVALUE dcvEmissive;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public float power;
        
        [FieldOffset(0)]
        public float dvPower;
    }
    
    public uint dwSize;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
    public _Anonymous4_e__Union Anonymous4;
    public _Anonymous5_e__Union Anonymous5;
    public uint hTexture;
    public uint dwRampSize;
}
