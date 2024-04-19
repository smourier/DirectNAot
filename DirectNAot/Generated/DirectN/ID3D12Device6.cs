namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device6
[GeneratedComInterface, Guid("c70b221b-40e4-4a17-89af-025a0727a6dc")]
public partial interface ID3D12Device6 : ID3D12Device5
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device6-setbackgroundprocessingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundProcessingMode(D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, HANDLE hEventToSignalUponCompletion, nint/* nint */ pbFurtherMeasurementsDesired);
}
