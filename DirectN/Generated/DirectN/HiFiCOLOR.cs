#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-hificolor
public partial struct HiFiCOLOR : IValueGet<byte[]>
{
    public InlineArrayByte_8 channel;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)channel).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)channel).ToArray();
}
