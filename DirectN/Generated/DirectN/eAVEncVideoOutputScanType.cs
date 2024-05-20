#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencvideooutputscantype
public enum eAVEncVideoOutputScanType
{
    eAVEncVideoOutputScan_Progressive = 0,
    eAVEncVideoOutputScan_Interlaced = 1,
    eAVEncVideoOutputScan_SameAsInput = 2,
    eAVEncVideoOutputScan_Automatic = 3,
}
