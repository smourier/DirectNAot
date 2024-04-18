namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-dxapi_interface
[StructLayout(LayoutKind.Sequential)]
public partial struct DXAPI_INTERFACE
{
    public ushort Size;
    public ushort Version;
    public nint Context;
    public nint InterfaceReference;
    public nint InterfaceDereference;
    public nint DxGetIrqInfo;
    public nint DxEnableIrq;
    public nint DxSkipNextField;
    public nint DxBobNextField;
    public nint DxSetState;
    public nint DxLock;
    public nint DxFlipOverlay;
    public nint DxFlipVideoPort;
    public nint DxGetPolarity;
    public nint DxGetCurrentAutoflip;
    public nint DxGetPreviousAutoflip;
    public nint DxTransfer;
    public nint DxGetTransferStatus;
}
