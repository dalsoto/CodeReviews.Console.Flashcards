namespace FlashcardsApp.DTOs;

internal class FlashcardDTO
{
    public int DisplayNumber { get; set; }
    public int FlashcardId { get; set; }
    public string Front { get; set; }
    public string Back { get; set; }
    public DateTime CreatedDate { get; set; }
}
