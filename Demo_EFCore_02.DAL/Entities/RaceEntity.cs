using System.ComponentModel;

namespace Demo_EFCore_02.DAL.Entities
{
    public class RaceEntity
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? AlternateName { get; set; }
    }
}
