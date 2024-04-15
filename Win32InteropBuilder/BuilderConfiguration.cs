﻿using System.Collections.Generic;
using System.Text;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder
{
    public class BuilderConfiguration
    {
        public virtual string? BuilderTypeFilePath { get; set; }
        public virtual string? BuilderTypeName { get; set; }
        public virtual string? WinMdPath { get; set; }
        public virtual string? OutputDirectoryPath { get; set; }
        public virtual bool DeleteOutputDirectory { get; set; }
        public virtual Encoding? OutputEncoding { get; set; }
        public virtual EncodingDetectorMode EncodingDetectorMode { get; set; }
        public virtual bool RemoveNonGeneratedFiles { get; set; } = true;
        public virtual IList<BuilderInput> Inputs { get; set; } = [];
        public virtual Encoding FinalOutputEncoding => OutputEncoding ?? Encoding.UTF8;
        public virtual BuilderGeneration Generation { get; set; } = new();

        public class BuilderGeneration
        {
            public virtual string? UnifiedNamespace { get; set; }
            public virtual bool HandleToIntPtr { get; set; } //= true;
            public virtual bool HRESULTIsError { get; set; } = true;
        }
    }
}
