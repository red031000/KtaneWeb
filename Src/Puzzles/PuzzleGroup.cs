﻿using System;
using System.Collections.Generic;
using RT.Util.Serialization;

namespace KtaneWeb.Puzzles
{
    sealed class PuzzleGroup
    {
        public string Title = "Untitled puzzle group";
        public string Author = "Unknown author";
        public DateTime Published = new DateTime(2000, 1, 1);
        public string Folder = "Unknown";
        public bool IsPublished = false;

        [ClassifyNotNull]
        public List<string> ViewAccess = new List<string> { "Timwi" };
        [ClassifyNotNull]
        public List<string> EditAccess = new List<string> { "Timwi" };

        [ClassifyNotNull]
        public List<Puzzle> Puzzles = new List<Puzzle>();

        public bool CanView(KtaneWebSession session) => ViewAccess.Contains(session.Username);
        public bool CanEdit(KtaneWebSession session) => EditAccess.Contains(session.Username);
    }
}
