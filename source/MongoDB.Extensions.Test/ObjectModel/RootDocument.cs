﻿using System;

namespace MongoDB.Extensions.Test.ObjectModel
{
    public class RootDocument
    {
        public String Id { get; set; }
        public Int32 Value { get; set; }
        public ChildDocument Child { get; set; }
    }
}
