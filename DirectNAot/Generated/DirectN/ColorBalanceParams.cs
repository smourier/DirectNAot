#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorBalanceParams
{
    public int cyanRed;
    public int magentaGreen;
    public int yellowBlue;
}
