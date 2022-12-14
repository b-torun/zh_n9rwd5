using System;
using System.Collections.Generic;

namespace zh_n9rwd5.Models;

public partial class Vásárló
{
    public string VásárlóAzon { get; set; } = null!;

    public string VásárlóNév { get; set; } = null!;

    public string VásárlóOrszág { get; set; } = null!;

    public string ÜgynökAzon { get; set; } = null!;

    public virtual ICollection<Rendelések> Rendelések { get; } = new List<Rendelések>();

    public virtual Ügynökök ÜgynökAzonNavigation { get; set; } = null!;
}
