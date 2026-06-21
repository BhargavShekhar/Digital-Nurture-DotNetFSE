namespace EcommerceSearchFunction
{
    public class SearchService
    {
        private List<Product> _products;

        public SearchService(List<Product> products)
        {
            _products = products;
        }

        public Product? LinearSearch(string productName)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return _products[i];
                }
            }
            return null;
        }
        public Product? BinarySearch(string productName)
        {
            List<Product> sortedProducts = _products
                .OrderBy(p => p.ProductName, StringComparer.OrdinalIgnoreCase)
                .ToList();

            int left = 0;
            int right = sortedProducts.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = sortedProducts[mid].ProductName.CompareTo(productName);

                if (comparison == 0)
                {
                    return sortedProducts[mid];
                }
                else if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }
}
