namespace Activator.Models
{
    public class Category
    {
        public string Type1 { get; set; }
        public string Type2 { get; set; }

        public override string ToString()
        {
            return $"Type1: {Type1}, Type2: {Type2}";
        }
    }
}
