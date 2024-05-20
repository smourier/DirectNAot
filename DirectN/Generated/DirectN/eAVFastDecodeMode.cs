#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavfastdecodemode
public enum eAVFastDecodeMode
{
    eVideoDecodeCompliant = 0,
    eVideoDecodeOptimalLF = 1,
    eVideoDecodeDisableLF = 2,
    eVideoDecodeFastest = 32,
}
