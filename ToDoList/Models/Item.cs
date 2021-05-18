namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int Done { get; set; } = 0;
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}