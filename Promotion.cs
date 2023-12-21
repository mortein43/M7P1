namespace M7P1;

internal class Promotion
{
    public int PromotionId { get; set; }
    public string Section { get; set; }
    public string Country { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<PromotedItem> PromotedItems { get; set; } = new List<PromotedItem>();
}
