﻿using Avtec.DevMorningFix;
using System.Collections.Generic;

namespace Avtec.NetCoreWebApp.Fundamentals
{
    public interface IFundamentalAccess
    {
        DevFixFundamental GetFundamental(string id);
        List<DevFixFundamental> GetFundamentals();
    }
}