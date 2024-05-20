#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-amcoppsignature
[StructLayout(LayoutKind.Sequential)]
public partial struct AMCOPPSignature
{
    public InlineArrayByte_256 Signature;
}
