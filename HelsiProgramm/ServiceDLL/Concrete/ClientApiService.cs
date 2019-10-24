using HelsiProgramm.Interfaces;
using Newtonsoft.Json;
using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ServiceDLL.Models.ClientModel;

namespace ServiceDLL.Concrete
{
    class ClientApiService : IClientService
    {
        private string _url = "https://localhost:44340/api/values";
        public int Create(ClientModel client)
        {
            var http = (HttpWebRequest)WebRequest.Create(new Uri(_url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = JsonConvert.SerializeObject(client);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            return 0;
        }
        public List<ClinicModels> GetClinics()
        {
            Debug.WriteLine("-----GetProducts() thread----- {0}",
                Thread.CurrentThread.ManagedThreadId);

            var client = new WebClient();
            client.Encoding = ASCIIEncoding.UTF8;
            string data = client.DownloadString(_url);
            var list = JsonConvert.DeserializeObject<List<ClinicModels>>(data);
            return list;
        }
        public Task<List<ClinicModels>> GetProductsAsync()
        {
            return Task.Run(() => GetClinics());
        }

    }
}
