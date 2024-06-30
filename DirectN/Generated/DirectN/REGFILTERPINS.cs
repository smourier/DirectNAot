#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-regfilterpins
public partial struct REGFILTERPINS
{
    public PWSTR strName;
    public BOOL bRendered;
    public BOOL bOutput;
    public BOOL bZero;
    public BOOL bMany;
    public nint clsConnectsToFilter;
    public PWSTR strConnectsToPin;
    public uint nMediaTypes;
    public nint lpMediaType;
}
