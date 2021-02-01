﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SophiAppCE.Commons
{
    internal static class Localization
    {
        internal static string RequirementTest_WinVer_Name = Application.Current.FindResource("Localization.RequirementTest.WinVer.Name") as string;
        internal static string RequirementTest_WinVer_ErrorDescription = Application.Current.FindResource("Localization.RequirementTest.WinVer.ErrorDescription") as string;
        internal static string RequirementTest_WinVer_Url = Application.Current.FindResource("Localization.RequirementTest.WinVer.Url") as string;
        internal static string DataLoading = Application.Current.FindResource("Localization.DataLoading") as string;
    }
}
