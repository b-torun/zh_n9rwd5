using System;
using System.Collections.Generic;

namespace zh_n9rwd5.Models;

public partial class Ügynökök
{
    public string ÜgynökAzon { get; set; } = null!;

    public string? ÜgynökNév { get; set; }

    public string? Telefon { get; set; }

    public virtual ICollection<Rendelések> Rendelések { get; } = new List<Rendelések>();

    public virtual ICollection<Vásárló> Vásárló { get; } = new List<Vásárló>();
}
