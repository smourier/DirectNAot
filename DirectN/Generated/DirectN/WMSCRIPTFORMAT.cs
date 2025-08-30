#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmscriptformat
public partial struct WMSCRIPTFORMAT : IValueGet<Guid>
{
    public Guid scriptType;
    
    readonly Guid IValueGet<Guid>.GetValue() => scriptType;
    readonly object? IValueGet.GetValue() => scriptType;
}
