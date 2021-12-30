using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
  [Table("activities")]
  public class Activity
  {
    [Column("id")]
    public Guid Id { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("category")]
    public string Category { get; set; }

    [Column("city")]
    public string City { get; set; }

    [Column("venue")]
    public string venue { get; set; }
  }
}