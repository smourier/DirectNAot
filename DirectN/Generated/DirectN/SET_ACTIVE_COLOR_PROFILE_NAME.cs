#nullable enable
namespace DirectN;

public partial struct SET_ACTIVE_COLOR_PROFILE_NAME : IValueGet<char[]>
{
    public InlineArraySystemChar_1 ColorProfileName; // variable-length array placeholder
    
    readonly char[]? IValueGet<char[]>.GetValue() => ((ReadOnlySpan<char>)ColorProfileName).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<char>)ColorProfileName).ToArray();
}
