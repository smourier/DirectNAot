#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-paramdescex
public partial struct PARAMDESCEX
{
    public uint cBytes;
    public VARIANT varDefaultValue;
}
