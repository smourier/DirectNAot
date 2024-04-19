﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/ns-spatialaudioclient-spatialaudioclientactivationparams
[StructLayout(LayoutKind.Sequential)]
public partial struct SpatialAudioClientActivationParams
{
    public Guid tracingContextId;
    public Guid appId;
    public int majorVersion;
    public int minorVersion1;
    public int minorVersion2;
    public int minorVersion3;
}
