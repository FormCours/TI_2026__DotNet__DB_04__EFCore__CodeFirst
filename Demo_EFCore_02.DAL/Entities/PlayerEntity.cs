namespace Demo_EFCore_02.DAL.Entities
{
    public class PlayerEntity
    {
        public required int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string? Pseudo { get; set; }

        // ↓ Navigation

        // One to Many avec Character
        public ICollection<CharacterEntity> Characters { get; set; } = [];

        // One to Many avec Campaign
        public ICollection<CampaignEntity> CampaignRuns { get; set; } = [];
    }
}
