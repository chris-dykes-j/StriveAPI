namespace StriveAPI.Models;

public class CharacterDto
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = string.Empty;
    public ICollection<MoveDto> MoveList { get; set; } = new List<MoveDto>();
}
