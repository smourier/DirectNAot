namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wiccomponentsigning
public enum WICComponentSigning
{
    WICComponentSigned = 1,
    WICComponentUnsigned = 2,
    WICComponentSafe = 4,
    WICComponentDisabled = int.MinValue,
}
