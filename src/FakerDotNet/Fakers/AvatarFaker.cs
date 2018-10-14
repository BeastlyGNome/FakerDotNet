namespace FakerDotNet.Fakers
{
    public interface IAvatarFaker
    {
        string Image();
        string Image(string slug);
        string Image(string slug, string size);
        string Image(string slug, string size, string format);
        string Image(string slug, string size, string format, string set);
        string Image(string slug, string size, string format, string set, string bgset);
    }
    
    internal class AvatarFaker : IAvatarFaker
    {
        private readonly IFakerContainer _fakerContainer;

        public AvatarFaker(IFakerContainer fakerContainer)
        {
            _fakerContainer = fakerContainer;
        }
        
        public string Image()
        {
            return Image(null, "300x300", "png", "set1", null);
        }

        public string Image(string slug)
        {
            return Image(slug, "300x300", "png", "set1", null);
        }

        public string Image(string slug, string size)
        {
            return Image(slug, size, "png", "set1", null);
        }

        public string Image(string slug, string size, string format)
        {
            return Image(slug, size, format, "set1", null);
        }

        public string Image(string slug, string size, string format, string set)
        {
            return Image(slug, size, format, set, null);
        }

        public string Image(string slug, string size, string format, string set, string bgset)
        {
            throw new System.NotImplementedException();
        }
    }
}
