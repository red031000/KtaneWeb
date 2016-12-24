﻿using System;
using System.Collections.Generic;
using System.IO;
using RT.TagSoup;
using RT.Util;
using RT.Util.Serialization;

namespace KtaneWeb
{
    public sealed class KtaneModuleInfo
    {
        public string Name;
        public string SortKey;
        public string SteamID;
        public KtaneModuleType Type;
        public KtaneModuleOrigin Origin;
        public string Author;
        public string SourceUrl;

        [ClassifyNotNull]
        public Dictionary<string, string> CheatSheatAuthors = new Dictionary<string, string>();

        public object Icon(KtaneWebConfig config) => Path.Combine(config.ModIconDir, Name + ".png")
            .Apply(f => new IMG { class_ = "mod-icon", alt = Name, title = Name, src = $"data:image/png;base64,{Convert.ToBase64String(File.ReadAllBytes(File.Exists(f) ? f : Path.Combine(config.ModIconDir, "blank.png")))}" });
    }
}