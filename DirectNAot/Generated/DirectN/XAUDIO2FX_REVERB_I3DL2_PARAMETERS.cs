#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2fx/ns-xaudio2fx-xaudio2fx_reverb_i3dl2_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2FX_REVERB_I3DL2_PARAMETERS
{
    public float WetDryMix;
    public int Room;
    public int RoomHF;
    public float RoomRolloffFactor;
    public float DecayTime;
    public float DecayHFRatio;
    public int Reflections;
    public float ReflectionsDelay;
    public int Reverb;
    public float ReverbDelay;
    public float Diffusion;
    public float Density;
    public float HFReference;
}
