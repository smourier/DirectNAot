#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9_sampleformat
public enum VMR9_SampleFormat
{
    VMR9_SampleReserved = 1,
    VMR9_SampleProgressiveFrame = 2,
    VMR9_SampleFieldInterleavedEvenFirst = 3,
    VMR9_SampleFieldInterleavedOddFirst = 4,
    VMR9_SampleFieldSingleEven = 5,
    VMR9_SampleFieldSingleOdd = 6,
}
