namespace Demo_EFCore_02.DAL.Entities
{
    public class PlayerEntity
    {
        public required int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string? Pseudo { get; set; }
    }
}
