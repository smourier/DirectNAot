#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavdecvideoinputscantype
public enum eAVDecVideoInputScanType
{
    eAVDecVideoInputScan_Unknown = 0,
    eAVDecVideoInputScan_Progressive = 1,
    eAVDecVideoInputScan_Interlaced_UpperFieldFirst = 2,
    eAVDecVideoInputScan_Interlaced_LowerFieldFirst = 3,
}
