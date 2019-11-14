﻿using Newtonsoft.Json;
using ServiceDLL.Interfaces;
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

namespace ServiceDLL.Concrete
{

    public class CityApiService : ICityService
    {
        private string _url = "https://localhost:44340/api/cities";
        public int CreateCity(CityModel city)
        {
            var http = (HttpWebRequest)WebRequest.Create(new Uri(_url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = JsonConvert.SerializeObject(city);
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

        public List<CityModel> GetCities()
        {
            Debug.WriteLine("-----GetClinics() thread----- {0}",
                 Thread.CurrentThread.ManagedThreadId);

            var clinic = new WebClient();
            clinic.Encoding = ASCIIEncoding.UTF8;
            string data = clinic.DownloadString(_url);
            var list = JsonConvert.DeserializeObject<List<CityModel>>(data);
            return list;
        }

        public Task<List<CityModel>> GetCitiesAsync()
        {
            return Task.Run(() => GetCities());
        }
    }
}