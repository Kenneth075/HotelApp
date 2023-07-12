using System;
using System.Collections.Generic;

namespace HotelApp.Models;

public partial class RegUsersTbl
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? DateTime { get; set; }
}
