using WebNetMentoringAPI.Interfaces;
using WebNetMentoringAPI.Models;

namespace WebNetMentoringAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBShopContext _context;
        public ProductRepository(DBShopContext context)
        {
            _context = context;
        }

        public bool CreateProduct(Product product)
        {
            _context.Add(product);

            return Save();
        }

        public bool UpdateProduct(Product product)
        {
            _context.Update(product);
            return Save();
        }

        public bool DeleteProduct(Product product)
        {
            _context.Remove(product);
            return Save();
        }

        public ICollection<Product> GetProducts()
        {
            return _context.Products.OrderBy(c => c.Id).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Where(c => c.Id == id).FirstOrDefault();
        }

        public Product GetProduct(string name)
        {
            return _context.Products.Where(c => c.Name == name).FirstOrDefault();
        }

        public bool ProductExists(int id)
        {
            return _context.Products.Any(c => c.Id == id);
        }

        public bool Save()
        {
            var save = _context.SaveChanges();

            return save > 0 ? true : false;
        }
    }
}
