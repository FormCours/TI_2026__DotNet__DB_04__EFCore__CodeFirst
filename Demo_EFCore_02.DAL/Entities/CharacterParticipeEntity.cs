namespace Demo_EFCore_02.DAL.Entities
{
    public class CharacterParticipeEntity
    {
        public required int CharacterId { get; set; }
        public required int CampaignId { get; set; }
        public required bool IsNPC { get; set; }

        // Navigation
        public CharacterEntity Character { get; set; }
        public CampaignEntity Campaign { get; set; }
    }
}