﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfmediakeystatus
[StructLayout(LayoutKind.Sequential)]
public partial struct MFMediaKeyStatus
{
    public nint pbKeyId;
    public uint cbKeyId;
    public MF_MEDIAKEY_STATUS eMediaKeyStatus;
}