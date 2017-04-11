﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeDownloader
{
    public class YouTubeResult
    {
        public DownloadFile ProcessedFile { get; set; }

        public bool HasError { get; set; }

        public string Error { get; set; }
    }
}
