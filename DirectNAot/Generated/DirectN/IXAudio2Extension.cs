#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("84ac29bb-d619-44d2-b197-e4acf7df3ed6")]
public partial interface IXAudio2Extension
{
    [PreserveSig]
    void GetProcessingQuantum(out uint quantumNumerator, ref uint quantumDenominator);
    
    [PreserveSig]
    void GetProcessor(ref uint processor);
}
