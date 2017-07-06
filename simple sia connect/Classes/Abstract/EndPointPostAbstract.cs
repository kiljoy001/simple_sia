using System.Threading.Tasks;
using System.Net.Http;

namespace simple_sia_connect.Classes.Abstract
{
    public abstract class EndPointPostAbstract:IEndPoint
    {
        public abstract string Agent { get; }
        public abstract string Address { get; }
        public abstract Task Post(HttpClient client);
    }
}
