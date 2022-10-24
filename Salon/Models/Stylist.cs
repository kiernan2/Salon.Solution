namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
  }
}