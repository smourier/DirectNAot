#nullable enable
namespace DirectN;

public enum SpeechEmulationCompareFlags
{
    SECFIgnoreCase = 1,
    SECFIgnoreKanaType = 65536,
    SECFIgnoreWidth = 131072,
    SECFNoSpecialChars = 536870912,
    SECFEmulateResult = 1073741824,
    SECFDefault = 196609,
}
