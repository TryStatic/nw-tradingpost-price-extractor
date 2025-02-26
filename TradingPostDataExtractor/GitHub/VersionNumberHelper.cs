﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingPostDataExtractor.GitHub
{
    public class VersionNumberHelper
    {
        public static int GetNumericVersionNumber(string version)
        {
            var versionString = version.Replace(".", string.Empty);
            if (int.TryParse(versionString, out var result))
            {
                return result;
            }

            return 0;
        }
    }
}
