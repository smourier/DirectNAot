namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_WIN32K_CALLBACKS_PARAMS
{
    public VIDEO_WIN32K_CALLBACKS_PARAMS_TYPE CalloutType;
    public nint PhysDisp;
    public nuint Param;
    public int Status;
    public BOOLEAN LockUserSession;
    public BOOLEAN IsPostDevice;
    public BOOLEAN SurpriseRemoval;
    public BOOLEAN WaitForQueueReady;
}
