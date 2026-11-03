namespace Demo_EFCore_02.DAL.Entities
{
    public class SpecializationEntity
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public int? MinLevel { get; set; }


        // ↓ Propriétés de navigation : One to Many recursive

        // - Require
        public int? RequirementId { get; set; }
        public SpecializationEntity? Requirement { get; set; }

        // - IsRequireOf
        public ICollection<SpecializationEntity> SubSpecializations { get; set; } = [];
    }
}
