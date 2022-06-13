namespace WebNetMentoringProject.Models
{
    public interface ICategory
    {
        string? Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        byte[]? Picture { get; set; }
        Product? Product { get; set; }
    }
}