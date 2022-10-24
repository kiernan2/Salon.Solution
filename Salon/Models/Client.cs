using System.Collections.Generic;

namespace Salon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public virtual ICollection<Stylist> StylistList { get; set; }

    public Client()
    {
      this.StylistList = new HashSet<Stylist>();
    }
  }
}