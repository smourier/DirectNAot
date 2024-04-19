namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfsensordevicetype
public enum MFSensorDeviceType
{
    MFSensorDeviceType_Unknown = 0,
    MFSensorDeviceType_Device = 1,
    MFSensorDeviceType_MediaSource = 2,
    MFSensorDeviceType_FrameProvider = 3,
    MFSensorDeviceType_SensorTransform = 4,
}
