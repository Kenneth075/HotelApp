﻿using System;
using System.Collections.Generic;

namespace HotelApp.Models;

public partial class PictureTbl
{
    public string HotelImageUrl { get; set; } = null!;

    public string HotelName { get; set; } = null!;

    public string HotelLocation { get; set; } = null!;

    public string? HotelPrice { get; set; }

    public string? HotelDescription { get; set; }

    public string? HotelGroup { get; set; }

    public string? HotelPopularity { get; set; }

    public string? IsPopular { get; set; }
}