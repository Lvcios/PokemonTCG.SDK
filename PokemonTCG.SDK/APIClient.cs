using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PokemonTCG.SDK.Model;

namespace PokemonTCG.SDK
{
    public sealed class APIClient<T>
    {
        private static readonly APIClient<T> client = new APIClient<T>();
        private static readonly string endPoint = "https://api.pokemontcg.io/v1/";
        public static APIClient<T> GetClient()
        {
            return client;
        }

        private APIClient()
        {

        }

        public T All(string resource, string query)
        {
            try
            {
                T result;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(endPoint);
                    HttpResponseMessage response = client.GetAsync(string.Format("{0}?{1}", resource, query)).Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string responseString = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<T>(responseString);
                    }
                    else
                    {
                        result = default(T);
                    }
                }
                return result;
            }
            catch
            {
                return default(T);
            }
        }

        public T Find(string resource, string id)
        {
            try
            {
                T result;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(endPoint);
                    HttpResponseMessage response = client.GetAsync(string.Format("{0}/{1}", resource, id)).Result;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string responseString = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<T>(responseString);
                    }
                    else
                    {
                        result = default(T);
                    }
                }
                return result;
            }
            catch
            {
                return default(T);
            }
        }
    }
}
