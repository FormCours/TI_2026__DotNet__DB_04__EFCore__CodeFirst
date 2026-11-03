namespace Demo_EFCore_02.DAL.Entities
{
    public class CampaignEntity
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Univers { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime? EndDate { get; set; }

        // Navigation

        // - One to Many avec Player (MJ)
        public int RunnerId { get; set; }
        public PlayerEntity Runner { get; set; }

        // - Many to Many avec Characters
        public ICollection<CharacterEntity> Characters { get; set; } = [];
        public ICollection<CharacterParticipeEntity> CharacterParticipes { get; set; } = [];
    }
}
