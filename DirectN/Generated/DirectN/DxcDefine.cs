#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DxcDefine
{
    public PWSTR Name;
    public PWSTR Value;
}
