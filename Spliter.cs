using System;
using System.Collections.Generic;

namespace MasterMind
{
    public static class Spliter
    {
      public static IEnumerable<String> SplitToSubstring( String fullString , Int32 lengthToCut) 
      {
        if (fullString == null)
          throw new ArgumentNullException(nameof(fullString));
        if (lengthToCut <= 0)
          throw new ArgumentException("Part length has to be positive.", nameof(fullString));

        for (var i = 0; i < fullString.Length; i += lengthToCut)
        yield return fullString.Substring(i, Math.Min(lengthToCut, fullString.Length - i));
      }
  }
}