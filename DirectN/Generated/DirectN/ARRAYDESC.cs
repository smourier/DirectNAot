#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-arraydesc
[StructLayout(LayoutKind.Sequential)]
public partial struct ARRAYDESC
{
    public TYPEDESC tdescElem;
    public ushort cDims;
    public InlineArraySAFEARRAYBOUND_1 rgbounds; // variable-length array placeholder
}
