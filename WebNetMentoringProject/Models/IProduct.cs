namespace WebNetMentoringProject.Models
{
    public interface IProduct
    {
        int? CategoryId { get; set; }
        string? Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        Category? oCategory { get; set; }
    }
}