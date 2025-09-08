#nullable enable
namespace DirectN;

public partial struct KSAUDIO_CHANNEL_CONFIG : IEquatable<KSAUDIO_CHANNEL_CONFIG>, IValueGet<int>
{
    public static readonly KSAUDIO_CHANNEL_CONFIG Null = new();
    
    public int ActiveSpeakerPositions;
    
    public KSAUDIO_CHANNEL_CONFIG(int value) => this.ActiveSpeakerPositions = value;
    public override readonly string ToString() => $"0x{ActiveSpeakerPositions:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSAUDIO_CHANNEL_CONFIG value && Equals(value);
    public readonly bool Equals(KSAUDIO_CHANNEL_CONFIG other) => other.ActiveSpeakerPositions == ActiveSpeakerPositions;
    public override readonly int GetHashCode() => ActiveSpeakerPositions.GetHashCode();
    public static bool operator ==(KSAUDIO_CHANNEL_CONFIG left, KSAUDIO_CHANNEL_CONFIG right) => left.Equals(right);
    public static bool operator !=(KSAUDIO_CHANNEL_CONFIG left, KSAUDIO_CHANNEL_CONFIG right) => !left.Equals(right);
    public static implicit operator int(KSAUDIO_CHANNEL_CONFIG value) => value.ActiveSpeakerPositions;
    public static implicit operator KSAUDIO_CHANNEL_CONFIG(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => ActiveSpeakerPositions;
    readonly object? IValueGet.GetValue() => ActiveSpeakerPositions;
}
