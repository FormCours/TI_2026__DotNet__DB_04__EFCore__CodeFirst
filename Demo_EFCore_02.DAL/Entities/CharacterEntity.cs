namespace Demo_EFCore_02.DAL.Entities
{
    public class CharacterEntity
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int Level { get; set; }
        public required DateTime CreateDate { get; set; }
        public required DateTime? DeathDate { get; set; }

        // ↓ Navigation

        // One to Many avec Player
        public required int PlayerId { get; set; }
        public PlayerEntity Player { get; set; }

        // One to Many avec Race
        public required int RaceId { get; set; }
        public RaceEntity Race { get; set; }

        // Many to Many avec Specialization
        public ICollection<SpecializationEntity> Specializations { get; set; } = [];

        // Many to Many avec Campaign
        public ICollection<CampaignEntity> Campaigns { get; set; } = [];
        public ICollection<CharacterParticipeEntity> CharacterParticipes { get; set; } = [];

    }
}
