namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2fx/ns-xaudio2fx-xaudio2fx_reverb_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2FX_REVERB_PARAMETERS
{
    public float WetDryMix;
    public uint ReflectionsDelay;
    public byte ReverbDelay;
    public byte RearDelay;
    public byte SideDelay;
    public byte PositionLeft;
    public byte PositionRight;
    public byte PositionMatrixLeft;
    public byte PositionMatrixRight;
    public byte EarlyDiffusion;
    public byte LateDiffusion;
    public byte LowEQGain;
    public byte LowEQCutoff;
    public byte HighEQGain;
    public byte HighEQCutoff;
    public float RoomFilterFreq;
    public float RoomFilterMain;
    public float RoomFilterHF;
    public float ReflectionsGain;
    public float ReverbGain;
    public float DecayTime;
    public float Density;
    public float RoomSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DisableLateField;
}
