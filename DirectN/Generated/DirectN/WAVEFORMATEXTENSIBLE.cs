#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-waveformatextensible
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFORMATEXTENSIBLE
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Samples_e__Union
    {
        [FieldOffset(0)]
        public ushort wValidBitsPerSample;
        
        [FieldOffset(0)]
        public ushort wSamplesPerBlock;
        
        [FieldOffset(0)]
        public ushort wReserved;
    }
    
    public WAVEFORMATEX Format;
    public _Samples_e__Union Samples;
    public uint dwChannelMask;
    public Guid SubFormat;
}
