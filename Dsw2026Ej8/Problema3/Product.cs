namespace Dsw2026Ej8.Problema3
{
    public class Product
    {
        public string Description { get; private set; }

        public Product(string description)
        {
            Description = description;
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription;
        }
    }
}