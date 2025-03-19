namespace HallOfFame.Domain.Models
{
    public class Skill: BaseModel
    {
        public string Name { get; set; }
        public byte Level { get; set; }
    }
}
