namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/ne-bdaiface-smartcardstatustype
public enum SmartCardStatusType
{
    CardInserted = 0,
    CardRemoved = 1,
    CardError = 2,
    CardDataChanged = 3,
    CardFirmwareUpgrade = 4,
}
