﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DHI.SDK.Examples
{
  public class UnitTestHelper
  {

    /// <summary>
    /// Relative path to test data. Must end with a \
    /// </summary>
    public static string TestDataRootRelative = @"..\..\..\..\TestData\";

    /// <summary>
    /// Path to test data
    /// </summary>
    public static string TestDataRoot
    {
      get { return (new Uri(Path.Combine(TestContext.CurrentContext.TestDirectory, TestDataRootRelative)).LocalPath); }
    }

  }
}
