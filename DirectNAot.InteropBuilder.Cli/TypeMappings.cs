using Win32InteropBuilder.Model;

namespace DirectNAot.InteropBuilder.Cli
{
    public static class TypeMappings
    {
        public const string GdiPlusNamespace = "Windows.Win32.Graphics.GdiPlus";

        public static FullName POINT { get; } = new(FullName.FoundationNamespace + ".POINT");
        public static FullName POINTL { get; } = new(FullName.FoundationNamespace + ".POINTL");
        public static FullName POINTS { get; } = new(FullName.FoundationNamespace + ".POINTS");
        public static FullName RECT { get; } = new(FullName.FoundationNamespace + ".RECT");
        public static FullName RECTL { get; } = new(FullName.FoundationNamespace + ".RECTL");
        public static FullName SIZE { get; } = new(FullName.FoundationNamespace + ".SIZE");

        public static FullName Size { get; } = new(GdiPlusNamespace + ".Size");
        public static FullName Rect { get; } = new(GdiPlusNamespace + ".Rect");
        public static FullName Point { get; } = new(GdiPlusNamespace + ".Point");

        // https://github.com/microsoft/win32metadata/issues/1896
        public static FullName DirectWriteDWRITE_PAINT_FEATURE_LEVEL { get; } = new("Windows.Win32.Graphics.DirectWrite.DWRITE_PAINT_FEATURE_LEVEL");
        public static FullName Direct2DDWRITE_PAINT_FEATURE_LEVEL { get; } = new("Windows.Win32.Graphics.Direct2D.DWRITE_PAINT_FEATURE_LEVEL");
    }
}
