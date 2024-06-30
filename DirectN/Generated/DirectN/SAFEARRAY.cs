#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-safearray
public partial struct SAFEARRAY
{
    public ushort cDims;
    public ADVANCED_FEATURE_FLAGS fFeatures;
    public uint cbElements;
    public uint cLocks;
    public nint pvData;
    public InlineArraySAFEARRAYBOUND_1 rgsabound; // variable-length array placeholder
}
