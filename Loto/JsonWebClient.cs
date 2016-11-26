using System.Net;
using System.Threading.Tasks;

namespace Loto
{
    class JsonWebClient
    {
        public async Task<System.IO.TextReader> DoRequestAsync(WebRequest req)
        {
            var task = Task.Factory.FromAsync((cb, o) => ((HttpWebRequest)o).BeginGetResponse(cb, o), res => ((HttpWebRequest)res.AsyncState).EndGetResponse(res), req);
            var result = await task;
            var resp = result;
            var stream = resp.GetResponseStream();
            var sr = new System.IO.StreamReader(stream);
            return sr;
        }

        public async Task<System.IO.TextReader> DoRequestAsync(string url)
        {
            HttpWebRequest req = HttpWebRequest.CreateHttp(url);
            req.AllowReadStreamBuffering = true;
            var tr = await DoRequestAsync(req);
            return tr;
        }
    }
}
