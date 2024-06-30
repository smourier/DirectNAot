#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.data.pdf.interop/ns-windows-data-pdf-interop-pdf_render_params
public partial struct PDF_RENDER_PARAMS
{
    public D2D_RECT_F SourceRect;
    public uint DestinationWidth;
    public uint DestinationHeight;
    public D3DCOLORVALUE BackgroundColor;
    public BOOLEAN IgnoreHighContrast;
}
