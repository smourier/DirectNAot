namespace DirectN.Extensions.Utilities
{
    public static partial class Pix
    {
        public const string DllName = "WinPixEventRuntime";

        public static void PIXEndEvent(IComObject<ID3D12GraphicsCommandList> commandList) => PIXEndEvent(commandList?.Object!);
        public static void PIXEndEvent(IComObject<ID3D12CommandQueue> commandQueue) => PIXEndEvent(commandQueue?.Object!);
        public static void PIXBeginEvent(IComObject<ID3D12GraphicsCommandList> commandList, ulong color, string formatString) => PIXBeginEvent(commandList?.Object!, color, formatString);
        public static void PIXBeginEvent(IComObject<ID3D12CommandQueue> commandQueue, ulong color, string formatString) => PIXBeginEvent(commandQueue?.Object!, color, formatString);
        public static void PIXSetMarker(IComObject<ID3D12GraphicsCommandList> commandList, ulong color, string formatString) => PIXSetMarker(commandList?.Object!, color, formatString);
        public static void PIXSetMarker(IComObject<ID3D12CommandQueue> commandQueue, ulong color, string formatString) => PIXSetMarker(commandQueue?.Object!, color, formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXEndEventOnCommandList")]
        public static partial void PIXEndEvent(ID3D12GraphicsCommandList commandList);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXEndEventOnCommandQueue")]
        public static partial void PIXEndEvent(ID3D12CommandQueue commandQueue);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXBeginEventOnCommandList")]
        public static partial void PIXBeginEvent(ID3D12GraphicsCommandList commandList, ulong color, string formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXBeginEventOnCommandQueue")]
        public static partial void PIXBeginEvent(ID3D12CommandQueue commandQueue, ulong color, string formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXSetMarkerOnCommandList")]
        public static partial void PIXSetMarker(ID3D12GraphicsCommandList commandList, ulong color, string formatString);

        [LibraryImport(DllName, StringMarshalling = StringMarshalling.Utf8, EntryPoint = "PIXSetMarkerOnCommandQueue")]
        public static partial void PIXSetMarker(ID3D12CommandQueue commandQueue, ulong color, string formatString);
    }
}
