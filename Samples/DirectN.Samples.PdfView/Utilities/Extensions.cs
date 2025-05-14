namespace DirectN.Samples.PdfView.Utilities;

public static class Extensions
{
    public static Color ToColor(this D3DCOLORVALUE value) => Color.FromArgb(value.BA, value.BR, value.BG, value.BB);
    public static D3DCOLORVALUE ToColor(this Color value) => D3DCOLORVALUE.FromArgb(value.A, value.R, value.G, value.B);
}
