using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDLL.Models;

namespace HelsiProgramm.Interfaces
{
    public interface IClientService
    {
        //List<ProductModel> GetProducts();
        //Task<List<ProductModel>> GetProductsAsync();
        int Create(ClientModel client);
    }
}
