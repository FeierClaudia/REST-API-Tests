using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer_Tests
{
    public class SymbolsResponse
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Symbols { get; set; }
    }
}
