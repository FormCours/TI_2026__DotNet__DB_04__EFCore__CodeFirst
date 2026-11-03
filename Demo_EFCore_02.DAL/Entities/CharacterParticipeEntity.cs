namespace Demo_EFCore_02.DAL.Entities
{
    public class CharacterParticipeEntity
    {
        public int CharacterId { get; set; }
        public int CampaignId { get; set; }
        public CharacterEntity Character { get; set; }
        public CampaignEntity Campaign { get; set; }

        public required bool IsNPC { get; set; }
    }
}