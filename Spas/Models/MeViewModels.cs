﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spas.Models {
    // MeController アクションによって返されるモデル。
    public class GetViewModel {
        public string Hometown { get; set; }
    }
}