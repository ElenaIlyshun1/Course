using Newtonsoft.Json;
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
   public class ScheduleApiService : IScheduleService
    {

        private string _url = "https://localhost:44340/api/schedule";
        public string CreateSchedule(ScheduleAddModel schedule)
        {
            var http = (HttpWebRequest)WebRequest.Create(new Uri(_url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = JsonConvert.SerializeObject(schedule);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();
            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            return content;
            //return tokenInfo.token;
        }
        public List<ScheduleModel> GetSchedule()
        {
            Debug.WriteLine("-----GetSchedule() thread----- {0}",
                Thread.CurrentThread.ManagedThreadId);

            var schedul = new WebClient();
            schedul.Encoding = ASCIIEncoding.UTF8;
            string data = schedul.DownloadString(_url);
            var list = JsonConvert.DeserializeObject<List<ScheduleModel>>(data);
            return list;
        }    
        public Task<List<ScheduleModel>> GetScheduleAsync()
        {
            return Task.Run(() => GetSchedule());
        }
    }
}
