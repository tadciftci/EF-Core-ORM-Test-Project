using System.Linq.Expressions;
using Assign_07.Models.DataLayer;

public static class ProductDB
{
    public static List<Product> GetProducts()
    {
        try
        {
            using (var context = new TechSupportContext())
            {
                return context.Products
                    .OrderBy(p => p.Name)
                    .ToList();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("DB Error: " + ex.Message);
            return new List<Product>();
        }
    }

    public static void AddProduct(Product product)
    {
        using (var context = new TechSupportContext())
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }

    public static void UpdateProduct(Product updatedProduct)
    {
        using (var context = new TechSupportContext())
        {
            var existingProduct = context.Products.Find(updatedProduct.ProductCode);
            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Version = updatedProduct.Version;
                existingProduct.ReleaseDate = updatedProduct.ReleaseDate;

                context.SaveChanges();
            }
        }
    }

    public static bool DeleteProduct(Product product)
    {
        using (var context = new TechSupportContext())
        {
            // Check for related Incidents or Registrations
            bool hasRelations = context.Incidents.Any(i => i.ProductCode == product.ProductCode) ||
                                context.Registrations.Any(r => r.ProductCode == product.ProductCode);

            if (hasRelations) return false;

            context.Products.Remove(product);
            context.SaveChanges();
            return true;
        }
    }

    public static Product? GetProduct(string productCode)
    {
        using (var context = new TechSupportContext())
        {
            return context.Products.Find(productCode);
        }
    }
}
