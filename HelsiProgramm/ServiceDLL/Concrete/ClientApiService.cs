using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDLL.Concrete
{
    class ClientApiService
    {
        //public class ProductApiService : IProductService
        //{
        //    public List<ProductModel> GetProducts()
        //    {
        //        Debug.WriteLine("-----GetProducts() thread----- {0}",
        //            Thread.CurrentThread.ManagedThreadId);
        //        string url = "https://localhost:44356/api/products";
        //        var client = new WebClient();
        //        client.Encoding = ASCIIEncoding.UTF8;
        //        string data = client.DownloadString(url);
        //        var list = JsonConvert.DeserializeObject<List<ProductModel>>(data);
        //        return list;
        //    }

        //    public Task<List<ProductModel>> GetProductsAsync()
        //    {
        //        return Task.Run(() => GetProducts());
        //    }
        //}
    }
}
