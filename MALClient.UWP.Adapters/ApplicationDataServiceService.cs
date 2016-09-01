﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;
using Windows.Storage;
using MALClient.Adapters;

namespace MALClient.UWP.Adapters
{
    public class ApplicationDataServiceService : IApplicationDataService
    {
        public object this[string key]
        {
            get { return ApplicationData.Current.LocalSettings.Values[key]; }
            set { ApplicationData.Current.LocalSettings.Values[key] = value; }
        }
    }
}
