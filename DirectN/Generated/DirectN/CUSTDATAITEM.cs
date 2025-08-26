#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-custdataitem
public partial struct CUSTDATAITEM
{
    public Guid guid;
    public VARIANT varValue;
}
