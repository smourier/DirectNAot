#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicpixelformatnumericrepresentation
public enum WICPixelFormatNumericRepresentation
{
    WICPixelFormatNumericRepresentationUnspecified = 0,
    WICPixelFormatNumericRepresentationIndexed = 1,
    WICPixelFormatNumericRepresentationUnsignedInteger = 2,
    WICPixelFormatNumericRepresentationSignedInteger = 3,
    WICPixelFormatNumericRepresentationFixed = 4,
    WICPixelFormatNumericRepresentationFloat = 5,
}
