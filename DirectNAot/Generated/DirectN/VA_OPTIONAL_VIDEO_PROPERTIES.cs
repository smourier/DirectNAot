namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VA_OPTIONAL_VIDEO_PROPERTIES
{
    public ushort dwPictureHeight;
    public ushort dwPictureWidth;
    public ushort dwAspectRatioX;
    public ushort dwAspectRatioY;
    public VA_VIDEO_FORMAT VAVideoFormat;
    public VA_COLOR_PRIMARIES VAColorPrimaries;
    public VA_TRANSFER_CHARACTERISTICS VATransferCharacteristics;
    public VA_MATRIX_COEFFICIENTS VAMatrixCoefficients;
}
