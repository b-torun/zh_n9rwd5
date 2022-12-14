using System;
using System.Collections.Generic;

namespace zh_n9rwd5.Models;

public partial class Rendelések
{
    public int RendelésAzon { get; set; }

    public float RendelésiMenny { get; set; }

    public float? Előleg { get; set; }

    public DateTime RendelésiDátum { get; set; }

    public string VásárlóAzon { get; set; } = null!;

    public string ÜgynökAzon { get; set; } = null!;

    public virtual Vásárló VásárlóAzonNavigation { get; set; } = null!;

    public virtual Ügynökök ÜgynökAzonNavigation { get; set; } = null!;
}
