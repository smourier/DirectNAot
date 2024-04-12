﻿using System.Collections.Generic;

namespace Win32InteropBuilder
{
    public class BuilderConfiguration
    {
        public virtual string? BuilderTypeFilePath { get; set; }
        public virtual string? BuilderTypeName { get; set; }
        public virtual IList<BuilderInput> Inputs { get; set; } = [];
    }
}