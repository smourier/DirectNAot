#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3ddevice9
[GeneratedComInterface, Guid("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb")]
public partial interface IDirect3DDevice9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-testcooperativelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TestCooperativeLevel();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getavailabletexturemem
    [PreserveSig]
    uint GetAvailableTextureMem();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-evictmanagedresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EvictManagedResources();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getdirect3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirect3D([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3D9>))] out IDirect3D9 ppD3D9);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getdevicecaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceCaps(ref D3DCAPS9 pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getdisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayMode(uint iSwapChain, ref D3DDISPLAYMODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getcreationparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreationParameters(ref D3DDEVICE_CREATION_PARAMETERS pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setcursorproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9 pCursorBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setcursorposition
    [PreserveSig]
    void SetCursorPosition(int X, int Y, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-showcursor
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL ShowCursor(BOOL bShow);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createadditionalswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAdditionalSwapChain(ref D3DPRESENT_PARAMETERS pPresentationParameters, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSwapChain9>))] out IDirect3DSwapChain9 pSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSwapChain(uint iSwapChain, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSwapChain9>))] out IDirect3DSwapChain9 pSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getnumberofswapchains
    [PreserveSig]
    uint GetNumberOfSwapChains();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(ref D3DPRESENT_PARAMETERS pPresentationParameters);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-present
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Present(in RECT pSourceRect, in RECT pDestRect, HWND hDestWindowOverride, in RGNDATA pDirtyRegion);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getbackbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DBACKBUFFER_TYPE Type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppBackBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getrasterstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRasterStatus(uint iSwapChain, ref D3DRASTER_STATUS pRasterStatus);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setdialogboxmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDialogBoxMode(BOOL bEnableDialogs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setgammaramp
    [PreserveSig]
    void SetGammaRamp(uint iSwapChain, uint Flags, in D3DGAMMARAMP pRamp);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getgammaramp
    [PreserveSig]
    void GetGammaRamp(uint iSwapChain, ref D3DGAMMARAMP pRamp);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createtexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTexture(uint Width, uint Height, uint Levels, uint Usage, D3DFORMAT Format, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DTexture9>))] out IDirect3DTexture9 ppTexture, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createvolumetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, D3DFORMAT Format, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVolumeTexture9>))] out IDirect3DVolumeTexture9 ppVolumeTexture, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createcubetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, D3DFORMAT Format, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DCubeTexture9>))] out IDirect3DCubeTexture9 ppCubeTexture, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createvertexbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVertexBuffer(uint Length, uint Usage, uint FVF, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVertexBuffer9>))] out IDirect3DVertexBuffer9 ppVertexBuffer, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createindexbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateIndexBuffer(uint Length, uint Usage, D3DFORMAT Format, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DIndexBuffer9>))] out IDirect3DIndexBuffer9 ppIndexBuffer, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRenderTarget(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, BOOL Lockable, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppSurface, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createdepthstencilsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDepthStencilSurface(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, BOOL Discard, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppSurface, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-updatesurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateSurface(IDirect3DSurface9 pSourceSurface, in RECT pSourceRect, IDirect3DSurface9 pDestinationSurface, in POINT pDestPoint);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-updatetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateTexture(IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9 pDestinationTexture);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getrendertargetdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderTargetData(IDirect3DSurface9 pRenderTarget, IDirect3DSurface9 pDestSurface);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getfrontbufferdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrontBufferData(uint iSwapChain, IDirect3DSurface9 pDestSurface);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-stretchrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StretchRect(IDirect3DSurface9 pSourceSurface, in RECT pSourceRect, IDirect3DSurface9 pDestSurface, in RECT pDestRect, D3DTEXTUREFILTERTYPE Filter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-colorfill
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ColorFill(IDirect3DSurface9 pSurface, in RECT pRect, uint color);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createoffscreenplainsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateOffscreenPlainSurface(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppSurface, ref HANDLE pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9 pRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderTarget(uint RenderTargetIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setdepthstencilsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDepthStencilSurface(IDirect3DSurface9 pNewZStencil);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getdepthstencilsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDepthStencilSurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppZStencilSurface);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-beginscene
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginScene();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-endscene
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndScene();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear(uint Count, in D3DRECT pRects, uint Flags, uint Color, float Z, uint Stencil);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-settransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransform(D3DTRANSFORMSTATETYPE State, in D3DMATRIX pMatrix);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-gettransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransform(D3DTRANSFORMSTATETYPE State, ref D3DMATRIX pMatrix);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-multiplytransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MultiplyTransform(D3DTRANSFORMSTATETYPE param0, in D3DMATRIX param1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setviewport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewport(in D3DVIEWPORT9 pViewport);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getviewport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewport(ref D3DVIEWPORT9 pViewport);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setmaterial
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaterial(in D3DMATERIAL9 pMaterial);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getmaterial
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaterial(ref D3DMATERIAL9 pMaterial);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setlight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLight(uint Index, in D3DLIGHT9 param1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getlight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLight(uint Index, ref D3DLIGHT9 param1);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-lightenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LightEnable(uint Index, BOOL Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getlightenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLightEnable(uint Index, ref BOOL pEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setclipplane
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipPlane(uint Index, in float pPlane);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getclipplane
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipPlane(uint Index, ref float pPlane);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setrenderstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderState(D3DRENDERSTATETYPE State, uint Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getrenderstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderState(D3DRENDERSTATETYPE State, ref uint pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createstateblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStateBlock(D3DSTATEBLOCKTYPE Type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DStateBlock9>))] out IDirect3DStateBlock9 ppSB);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-beginstateblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginStateBlock();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-endstateblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndStateBlock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DStateBlock9>))] out IDirect3DStateBlock9 ppSB);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setclipstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipStatus(in D3DCLIPSTATUS9 pClipStatus);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getclipstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipStatus(ref D3DCLIPSTATUS9 pClipStatus);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-gettexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTexture(uint Stage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DBaseTexture9>))] out IDirect3DBaseTexture9 ppTexture);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-settexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTexture(uint Stage, IDirect3DBaseTexture9 pTexture);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-gettexturestagestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextureStageState(uint Stage, D3DTEXTURESTAGESTATETYPE Type, ref uint pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-settexturestagestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextureStageState(uint Stage, D3DTEXTURESTAGESTATETYPE Type, uint Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getsamplerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSamplerState(uint Sampler, D3DSAMPLERSTATETYPE Type, ref uint pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setsamplerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSamplerState(uint Sampler, D3DSAMPLERSTATETYPE Type, uint Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-validatedevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ValidateDevice(ref uint pNumPasses);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setpaletteentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPaletteEntries(uint PaletteNumber, in PALETTEENTRY pEntries);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getpaletteentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPaletteEntries(uint PaletteNumber, ref PALETTEENTRY pEntries);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setcurrenttexturepalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentTexturePalette(uint PaletteNumber);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getcurrenttexturepalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentTexturePalette(ref uint PaletteNumber);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setscissorrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScissorRect(in RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getscissorrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScissorRect(ref RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setsoftwarevertexprocessing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSoftwareVertexProcessing(BOOL bSoftware);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getsoftwarevertexprocessing
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetSoftwareVertexProcessing();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setnpatchmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNPatchMode(float nSegments);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getnpatchmode
    [PreserveSig]
    float GetNPatchMode();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-drawprimitive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawPrimitive(D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-drawindexedprimitive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawIndexedPrimitive(D3DPRIMITIVETYPE param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-drawprimitiveup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, nint pVertexStreamZeroData, uint VertexStreamZeroStride);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-drawindexedprimitiveup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawIndexedPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, nint pIndexData, D3DFORMAT IndexDataFormat, nint pVertexStreamZeroData, uint VertexStreamZeroStride);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-processvertices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9 pVertexDecl, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createvertexdeclaration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVertexDeclaration(in D3DVERTEXELEMENT9 pVertexElements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVertexDeclaration9>))] out IDirect3DVertexDeclaration9 ppDecl);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setvertexdeclaration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexDeclaration(IDirect3DVertexDeclaration9 pDecl);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getvertexdeclaration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVertexDeclaration([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVertexDeclaration9>))] out IDirect3DVertexDeclaration9 ppDecl);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setfvf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFVF(uint FVF);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getfvf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFVF(ref uint pFVF);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVertexShader(in uint pFunction, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVertexShader9>))] out IDirect3DVertexShader9 ppShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexShader(IDirect3DVertexShader9 pShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVertexShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVertexShader9>))] out IDirect3DVertexShader9 ppShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setvertexshaderconstantf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexShaderConstantF(uint StartRegister, in float pConstantData, uint Vector4fCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getvertexshaderconstantf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setvertexshaderconstanti
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexShaderConstantI(uint StartRegister, in int pConstantData, uint Vector4iCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getvertexshaderconstanti
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setvertexshaderconstantb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexShaderConstantB(uint StartRegister, in BOOL pConstantData, uint BoolCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getvertexshaderconstantb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVertexShaderConstantB(uint StartRegister, ref BOOL pConstantData, uint BoolCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setstreamsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getstreamsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSource(uint StreamNumber, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DVertexBuffer9>))] out IDirect3DVertexBuffer9 ppStreamData, ref uint pOffsetInBytes, ref uint pStride);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setstreamsourcefreq
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSourceFreq(uint StreamNumber, uint Setting);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getstreamsourcefreq
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSourceFreq(uint StreamNumber, ref uint pSetting);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndices(IDirect3DIndexBuffer9 pIndexData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndices([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DIndexBuffer9>))] out IDirect3DIndexBuffer9 ppIndexData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePixelShader(in uint pFunction, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DPixelShader9>))] out IDirect3DPixelShader9 ppShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelShader(IDirect3DPixelShader9 pShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelShader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DPixelShader9>))] out IDirect3DPixelShader9 ppShader);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setpixelshaderconstantf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelShaderConstantF(uint StartRegister, in float pConstantData, uint Vector4fCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getpixelshaderconstantf
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setpixelshaderconstanti
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelShaderConstantI(uint StartRegister, in int pConstantData, uint Vector4iCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getpixelshaderconstanti
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-setpixelshaderconstantb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelShaderConstantB(uint StartRegister, in BOOL pConstantData, uint BoolCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-getpixelshaderconstantb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelShaderConstantB(uint StartRegister, ref BOOL pConstantData, uint BoolCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-drawrectpatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawRectPatch(uint Handle, in float pNumSegs, in D3DRECTPATCH_INFO pRectPatchInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-drawtripatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawTriPatch(uint Handle, in float pNumSegs, in D3DTRIPATCH_INFO pTriPatchInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-deletepatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeletePatch(uint Handle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9-createquery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQuery(D3DQUERYTYPE Type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DQuery9>))] out IDirect3DQuery9 ppQuery);
}
