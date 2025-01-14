﻿using Newtonsoft.Json;
using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static ServiceDLL.Models.ClientModel;

namespace ServiceDLL.Concrete
{
    public class AccountApiService
    {       
        public string Login(UserLoginVM login)
        {
            string _url = "https://localhost:44340/api/user/login";
            var http = (HttpWebRequest)WebRequest.Create(new Uri(_url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = JsonConvert.SerializeObject(login);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();
            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            var tokenInfo = new { token = "" };
            tokenInfo = JsonConvert.DeserializeAnonymousType(content, tokenInfo);
            return tokenInfo.token;
        }

        public string Register(ClientAddVM user)
        {
            string _url = "https://localhost:44340/api/user/registration";
            var http = (HttpWebRequest)WebRequest.Create(new Uri(_url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";

            string parsedContent = JsonConvert.SerializeObject(user);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();
            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();
            var tokenInfo = new { token = "" };
            tokenInfo = JsonConvert.DeserializeAnonymousType(content, tokenInfo);
            return tokenInfo.token;
        }        
    }
}
