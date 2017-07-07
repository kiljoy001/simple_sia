using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using simple_sia_connect.Classes.Daemon;
using simple_sia_connect.Classes.Consensus;
using simple_sia_connect.Classes.JSON_Models;
using Newtonsoft.Json;

namespace simple_sia_connect
{
    class Program
    {
        public static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            var test = new DaemonConstants();
            test.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test2 = new ConsensusStatus();
            test2.Connect(client).Wait();
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            var test3 = new ConsensusValidateTransactionSet();
            string json = @"{'blockid':'000000000000001ea80a6eeb11f8f0207ae8a81867574d38ce6f30d87c966633','difficulty':'179949455345760515','estimatedhashrate':'302169439311129','height':112992,'maturitytimestamp':1499232818,'target':[ 0, 0, 0, 0, 0, 0, 0, 102, 130, 189, 8, 38, 78, 199, 217, 128, 159, 248, 50, 154, 50, 44, 192, 41, 128, 21, 74, 71, 193, 173, 103, 98 ],'totalcoins':'27514247472000000000000000000000000','minerpayoutcount': 112992,'transactioncount': 4943770,'siacoininputcount': 5039043,'siacoinoutputcount': 6292259,'filecontractcount': 503956,'filecontractrevisioncount':235907,'storageproofcount': 72866,'siafundinputcount':499,'siafundoutputcount': 660,'minerfeecount': 1603198,'arbitrarydatacount': 520309,'transactionsignaturecount': 5511371,'activecontractcost': '4555653481882052742983470669728','activecontractcount': 37193,'activecontractsize': '18909172334592','totalcontractcost': '43907439762663069130010805248599','totalcontractsize': '187511945304602','totalrevisionvolume': '84169310535680'}";
            
            JsonUtxoModel model = JsonConvert.DeserializeObject<JsonUtxoModel>(json);
            string modeloutput = JsonConvert.SerializeObject(model);
            Console.WriteLine(modeloutput);
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            test3.Post(client).Wait();
            Console.ReadLine();
        }
      
    }
}