namespace DirectN;

public static partial class Functions
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-createdxgifactory
    [LibraryImport("dxgi")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory(in Guid riid, out nint ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-createdxgifactory1
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory1(in Guid riid, out nint ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-createdxgifactory2
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT CreateDXGIFactory2(uint Flags, in Guid riid, out nint ppFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-d2d1computemaximumscalefactor
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial float D2D1ComputeMaximumScaleFactor(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1convertcolorspace
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial D2D1_COLOR_F D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, in D2D1_COLOR_F color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1createdevice
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateDevice(IDXGIDevice dxgiDevice, nint /* D2D1_CREATION_PROPERTIES */ creationProperties, out ID2D1Device d2dDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1createdevicecontext
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows8.0")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateDeviceContext(IDXGISurface dxgiSurface, nint /* D2D1_CREATION_PROPERTIES */ creationProperties, out ID2D1DeviceContext d2dDeviceContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1createfactory
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, in Guid riid, nint /* D2D1_FACTORY_OPTIONS */ pFactoryOptions, out nint ppIFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-d2d1getgradientmeshinteriorpointsfromcoonspatch
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows10.0.10240")]
    [PreserveSig]
    public static partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(in D2D_POINT_2F pPoint0, in D2D_POINT_2F pPoint1, in D2D_POINT_2F pPoint2, in D2D_POINT_2F pPoint3, in D2D_POINT_2F pPoint4, in D2D_POINT_2F pPoint5, in D2D_POINT_2F pPoint6, in D2D_POINT_2F pPoint7, in D2D_POINT_2F pPoint8, in D2D_POINT_2F pPoint9, in D2D_POINT_2F pPoint10, in D2D_POINT_2F pPoint11, out D2D_POINT_2F pTensorPoint11, out D2D_POINT_2F pTensorPoint12, out D2D_POINT_2F pTensorPoint21, out D2D_POINT_2F pTensorPoint22);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1invertmatrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool D2D1InvertMatrix(ref D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1ismatrixinvertible
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public static partial bool D2D1IsMatrixInvertible(in D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1makerotatematrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial void D2D1MakeRotateMatrix(float angle, D2D_POINT_2F center, out D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-d2d1makeskewmatrix
    [LibraryImport("d2d1")]
    [SupportedOSPlatform("windows6.1")]
    [PreserveSig]
    public static partial void D2D1MakeSkewMatrix(float angleX, float angleY, D2D_POINT_2F center, out D2D_MATRIX_3X2_F matrix);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1sincos
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial void D2D1SinCos(float angle, out float s, out float c);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1tan
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial float D2D1Tan(float angle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-d2d1vec3length
    [LibraryImport("d2d1")]
    [PreserveSig]
    public static partial float D2D1Vec3Length(float x, float y, float z);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-dxgideclareadapterremovalsupport
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows10.0.17134")]
    [PreserveSig]
    public static partial HRESULT DXGIDeclareAdapterRemovalSupport();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-dxgidisablevblankvirtualization
    [LibraryImport("dxgi")]
    [PreserveSig]
    public static partial HRESULT DXGIDisableVBlankVirtualization();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-dxgigetdebuginterface1
    [LibraryImport("dxgi")]
    [SupportedOSPlatform("windows8.1")]
    [PreserveSig]
    public static partial HRESULT DXGIGetDebugInterface1(uint Flags, in Guid riid, out nint pDebug);
}
