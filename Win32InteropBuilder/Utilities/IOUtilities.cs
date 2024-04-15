using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Win32InteropBuilder.Utilities
{
    public static class IOUtilities
    {
        public static bool IsPathRooted(string path)
        {
            if (path == null)
                return false;

            var length = path.Length;
            if (length < 1 || (path[0] != Path.DirectorySeparatorChar && path[0] != Path.AltDirectorySeparatorChar))
                return length >= 2 && path[1] == Path.VolumeSeparatorChar;

            return true;
        }

        public static bool PathIsEqual(string path1, string path2, bool normalize = true)
        {
            ArgumentNullException.ThrowIfNull(path1);
            ArgumentNullException.ThrowIfNull(path2);
            if (normalize)
            {
                path1 = Path.GetFullPath(path1);
                path2 = Path.GetFullPath(path2);
            }

            return path1.EqualsIgnoreCase(path2);
        }

        public static bool FileOverwrite(string source, string destination, bool unprotect = true, bool throwOnError = true)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(destination);
            if (PathIsEqual(source, destination))
                return false;

            if (!throwOnError && !PathIsFile(source))
                return false;

            if (!FileEnsureDirectory(destination, throwOnError))
                return false;

            if (unprotect)
            {
                // we delete the target only if we can write to its directory
                if (DirectoryCheckCanWrite(Path.GetDirectoryName(destination)!))
                {
                    FileDelete(destination, unprotect, throwOnError);
                }
            }

            if (throwOnError)
            {
                File.Copy(source, destination, true);
            }
            else
            {
                try
                {
                    File.Copy(source, destination, true);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static bool DirectoryCheckCanWrite(string directoryPath)
        {
            ArgumentNullException.ThrowIfNull(directoryPath);
            if (!PathIsDirectory(directoryPath))
                return false;

            var guid = "temp" + Guid.NewGuid().ToString("N") + ".txt";
            var path = Path.Combine(directoryPath, guid);
            try
            {
                File.WriteAllText(path, "You can safely delete this file");
            }
            catch
            {
                return false;
            }

            FileDelete(path, false, false);
            return true;
        }

        public static void DirectoryDelete(string path, bool recursive, bool throwOnError = true)
        {
            ArgumentNullException.ThrowIfNull(path);
            if (!PathIsDirectory(path))
                return;

            if (throwOnError)
            {
                Directory.Delete(path, recursive);
                return;
            }

            try
            {
                Directory.Delete(path, recursive);
            }
            catch
            {
                // do nothing
            }
        }

        public static void DirectoryDeleteEmptySubDirectories(string path, bool throwOnError = true)
        {
            ArgumentNullException.ThrowIfNull(path);
            if (!PathIsDirectory(path))
                return;

            do
            {
                var hasDeletedAny = false;
                foreach (var directory in Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories))
                {
                    if (DirectoryIsEmpty(directory) == true)
                    {
                        DirectoryDelete(directory, throwOnError);
                        hasDeletedAny = true;
                    }
                }
                if (!hasDeletedAny)
                    break;
            }
            while (true);
        }

        public static bool FileDelete(string path, bool unprotect = true, bool throwOnError = true)
        {
            ArgumentNullException.ThrowIfNull(path);
            if (!PathIsFile(path))
                return false;

            if (throwOnError)
            {
                delete();
            }
            else
            {
                try
                {
                    delete();
                }
                catch
                {
                    return false;
                }
            }
            return true;

            void delete()
            {
                var attributes = File.GetAttributes(path);
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly && unprotect)
                {
                    File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
                }

                File.Delete(path);
            }
        }

        public static FileAttributes? PathGetAttributes(string path)
        {
            ArgumentNullException.ThrowIfNull(path);
            var data = new WIN32_FILE_ATTRIBUTE_DATA();
            if (!GetFileAttributesEx(path, GetFileExInfoStandard, ref data))
                return null;

            return data.fileAttributes;
        }

        public static bool PathExists(string path) => PathGetAttributes(path).HasValue;
        public static bool PathIsFile(string path)
        {
            var atts = PathGetAttributes(path);
            if (!atts.HasValue)
                return false;

            return !atts.Value.HasFlag(FileAttributes.Directory);
        }

        public static bool PathIsDirectory(string path)
        {
            var atts = PathGetAttributes(path);
            if (!atts.HasValue)
                return false;

            return atts.Value.HasFlag(FileAttributes.Directory);
        }

        public static bool? DirectoryIsEmpty(string path)
        {
            if (!PathIsDirectory(path))
                return null;

            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static bool FileEnsureDirectory(string path, bool throwOnError = true)
        {
            ArgumentNullException.ThrowIfNull(path);
            if (!IsPathRooted(path))
            {
                path = Path.GetFullPath(path);
            }

            var dir = Path.GetDirectoryName(path);
            if (dir == null)
                return false;

            if (PathIsDirectory(dir))
                return true;

            try
            {
                Directory.CreateDirectory(dir);
                return true;
            }
            catch
            {
                if (throwOnError)
                    throw;

                return false;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WIN32_FILE_ATTRIBUTE_DATA
        {
            public FileAttributes fileAttributes;
            public FILE_TIME ftCreationTime;
            public FILE_TIME ftLastAccessTime;
            public FILE_TIME ftLastWriteTime;
            public long fileSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct FILE_TIME(long fileTime)
        {
            public uint ftTimeLow = (uint)fileTime;
            public uint ftTimeHigh = (uint)(fileTime >> 32);

            public readonly bool IsZero => ftTimeHigh == 0 && ftTimeLow == 0;
            public readonly long ToTicks() => ((long)ftTimeHigh << 32) + ftTimeLow;
        }

        private const int GetFileExInfoStandard = 0;

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private extern static bool GetFileAttributesEx(string name, int fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation);
    }
}
