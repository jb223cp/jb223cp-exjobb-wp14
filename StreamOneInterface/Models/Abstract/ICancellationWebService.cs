﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamOneInterface.Models.Abstract
{
    public interface ICancellationWebService
    {
        void CancelSubscription(string provision_data, string token);
    }
}
