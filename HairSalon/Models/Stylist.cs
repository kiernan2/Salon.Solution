using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public int ClientId { get; set; }
    public virtual ICollection<Client> ClientList { get; set; }

    public Stylist()
    {
      this.ClientList = new HashSet<Client>();
    }
  }
}