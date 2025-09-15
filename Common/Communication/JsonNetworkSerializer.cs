﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class JsonNetworkSerializer
    {
        private readonly Socket s;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonNetworkSerializer(Socket s)
        {
            this.s = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
        }

        private static readonly JsonSerializerOptions Options = new()
        {
            
            ReferenceHandler = ReferenceHandler.IgnoreCycles, // rešava cikluse
          
        };

        public void Send(object z)
        {
            writer.WriteLine(JsonSerializer.Serialize(z,Options));
        }

        public T Receive<T>()
        {
            string json = reader.ReadLine();
            return JsonSerializer.Deserialize<T>(json,Options);
        }

        public T ReadType<T>(object podaci) where T : class
        {
            //if (podaci == null)
            //{
            //    return null;
            //}
            //return JsonSerializer.Deserialize<T>((JsonElement)podaci);
            return podaci == null ? null : JsonSerializer.Deserialize<T>((JsonElement)podaci,Options);
        }

        public void Close()
        {
            stream.Close();
            reader.Close();
            writer.Close();
        }
    }
}
