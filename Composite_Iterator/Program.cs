using Composite_Iterator.Composite_iterator_pattern;
using System;

namespace Composite_Iterator
{
    class Program
    {
        static Client _client;
        static void Main(string[] args)
        {
            _client = LoadSystem();
            PrintAIWorker();
        }
        private static void PrintAIWorker()
        {
            var text = _client.PrintAIWorker();
            Console.WriteLine(text);
        }
        private static Client LoadSystem()
        {
            Composite Tree = new Composite("Tree", "İt keeps All segments");
            Composite Web = new Composite("WebSegment", "İt keeps web_Worker");
            Composite Cyber = new Composite("CyberSegment", "İt keeps cyber_Worker");
            Composite AI = new Composite("AiSegment", "İt keeps AI_Worker");
            worker worker1 = new worker("Mustafa", "Clouder", 5000);
            worker worker2 = new worker("Ali", "Clouder", 5000);
            worker worker3 = new worker("Veli", "Clouder", 5000);
            worker worker4 = new worker("Emre", "AIworker", 5000);
            worker worker5 = new worker("Veli", "AIworker", 5000);
            worker worker6 = new worker("Kazım", "AIworker", 5000);
            worker worker7 = new worker("Ali", "AIworker", 5000);
            worker worker8 = new worker("veli", "Manager", 5000);
            worker worker9 = new worker("Zeynep", "Manager", 5000);
            worker worker10 = new worker("ŞtandartKazım", "SoftwareEn", 5000);
            worker worker11 = new worker("Memati", "SoftwareEn", 5000);
            worker worker12 = new worker("Cahit", "SoftwareEn", 5000);
            worker worker13 = new worker("Mehmet", "SoftwareEn", 5000);
            worker worker14 = new worker("Zeynep", "SoftwareEn", 5000);
            worker worker15 = new worker("Celil", "AIworker", 5000);
            worker worker16 = new worker("Polat", "Clouder", 5000);
            Composite AISub = new Composite("AISub", "SubAreaOfAI");
            worker denemeai = new worker("AliSub", "Manager", 50);
            AI.Add(AISub);
            Tree.Add(Web);
            Tree.Add(Cyber);
            Tree.Add(AI);
            AISub.Add(denemeai);
            Web.Add(worker16);
            Web.Add(worker15);
            Web.Add(worker12);
            Web.Add(worker10);
            Cyber.Add(worker14);
            Cyber.Add(worker13);
            Cyber.Add(worker12);
            Cyber.Add(worker10);
            Cyber.Add(worker8);
            Cyber.Add(worker5);
            AI.Add(worker1);
            AI.Add(worker2);
            AI.Add(worker4);
            AI.Add(worker5);
            AI.Add(worker6);
            AI.Add(worker11);
            AI.Add(worker7);
            AI.Add(worker9);
            Cyber.Add(worker3);
            Cyber.Add(worker4);
            Client client = new Client(Tree);
            return client;
        }

        private static void PrintManager()
        {
            var text = _client.PrintManagerWorker();
        }

        private static void PrintSoftwareEn()
        {
            var text = _client.PrintSoftwareEnWorker();
        }

        private static void PrintClouder()
        {
            var text = _client.PrintCloudWorker();
        }

        private static void PrintAll()
        {
            var text = _client.PrintFieldWithİterator();
        }
    }
}
