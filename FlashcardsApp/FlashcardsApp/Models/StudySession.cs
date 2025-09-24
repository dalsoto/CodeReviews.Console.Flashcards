namespace FlashcardsApp.Models;

internal class StudySession
{
    public int SessionId { get; set; }
    public int StackId { get; set; }
    public string Score { get; set; }
    public DateTime StudyDate { get; set; }
}
