namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/ne-bdaiface-uiclosereasontype
public enum UICloseReasonType
{
    NotReady = 0,
    UserClosed = 1,
    SystemClosed = 2,
    DeviceClosed = 3,
    ErrorClosed = 4,
}
