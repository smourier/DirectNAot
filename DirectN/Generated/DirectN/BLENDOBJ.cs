#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-blendobj
public partial struct BLENDOBJ : IValueGet<BLENDFUNCTION>
{
    public BLENDFUNCTION BlendFunction;
    
    readonly BLENDFUNCTION IValueGet<BLENDFUNCTION>.GetValue() => BlendFunction;
    readonly object? IValueGet.GetValue() => BlendFunction;
}
