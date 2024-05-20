#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicprogressoperation
public enum WICProgressOperation
{
    WICProgressOperationCopyPixels = 1,
    WICProgressOperationWritePixels = 2,
    WICProgressOperationAll = 65535,
}
