﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App8
{
    class Contact
    {
        public long Id { get; set; }

        public string DisplayName { get; set; }

        public string PhotoId { get; set; }
    }
}