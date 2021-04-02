using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator.Composite_iterator_pattern
{
    class Client
    {
        WorkerComponent allWorkerField;

        public Client(WorkerComponent allField)
        {
            allWorkerField = allField;
        }

        public string PrintField()
        {
            return allWorkerField.Print();
        }
        public string PrintFieldWithİterator()
        {
            StringBuilder Workers = new StringBuilder();
            IIterator iterator = allWorkerField.CreateIterator();
            while (iterator.hasNext())
            {
                WorkerComponent component = (WorkerComponent)iterator.next();
                try
                {
                    if (component is worker)
                    {
                        Workers.Append(component.Print());
                    }
                    else
                    {
                        Workers.Append("\n\n" + component.Name + component.Description + "\n" + "--------------------" + "\n");
                        Client client = new Client(component);
                        Workers.Append(client.PrintFieldWithİterator());
                    }
                }
                catch (UnsupportedOperationException e)
                {
                }
            }
            return Workers.ToString();

        }

        public string PrintAIWorker()
        {
            StringBuilder AIWorkers = new StringBuilder();
            IIterator iterator = allWorkerField.CreateIterator();
            while (iterator.hasNext())
            {
                WorkerComponent component = (WorkerComponent)iterator.next();
                try
                {
                    if (component is worker)
                    {
                        if (component.Description == "AIworker")
                        {
                            AIWorkers.Append(component.Print());
                        }
                    }
                    else
                    {
                        Client client = new Client(component);
                        AIWorkers.Append(client.PrintAIWorker());
                    }
                }
                catch (UnsupportedOperationException e)
                {
                }
                //while (iterator.hasNext())
                //{
                //    WorkerComponent component =  (WorkerComponent)iterator.next();
                //    try
                //    {
                //        if (component is worker)
                //        {
                //            AIWorkers.Append(component.Print());
                //        }
                //        else
                //        {
                //            foreach (WorkerComponent item in component.GetWorker())
                //            {
                //                if (item is worker)
                //                {
                //                    if (item.Description == "AIworker")
                //                    {
                //                        AIWorkers.Append(item.Print());
                //                    }
                //                }
                //                else
                //                {
                //                    Client client = new Client(item);
                //                    AIWorkers.Append(client.PrintAIWorker().ToString());
                //                }
                //            }
                //        }
                //    }
                //    catch (UnsupportedOperationException e)
                //    {
                //    }
            }
            return AIWorkers.ToString();
        }
        public string PrintCloudWorker()
        {
            StringBuilder AIWorkers = new StringBuilder();
            IIterator iterator = allWorkerField.CreateIterator();
            while (iterator.hasNext())
            {
                WorkerComponent component = (WorkerComponent)iterator.next();
                try
                {
                    if (component is worker)
                    {
                        if (component.Description == "Clouder")
                        {
                            AIWorkers.Append(component.Print());
                        }
                    }
                    else
                    {
                        Client client = new Client(component);
                        AIWorkers.Append(client.PrintCloudWorker());
                    }

                    //foreach (WorkerComponent item in component.GetWorker())
                    //{

                    //    if (item is worker)
                    //    {
                    //        if (item.Description == "Clouder")
                    //        {
                    //            AIWorkers.Append(item.Print());
                    //        }
                    //    }
                    //    else
                    //    {
                    //        Client client = new Client(item);
                    //        AIWorkers.Append(client.PrintCloudWorker().ToString());
                    //    }
                    //}

                }
                catch (UnsupportedOperationException e)
                {
                }
            }
            return AIWorkers.ToString();
        }
        public string PrintManagerWorker()
        {
            StringBuilder AIWorkers = new StringBuilder();
            IIterator iterator = allWorkerField.CreateIterator();
            while (iterator.hasNext())
            {
                WorkerComponent component = (WorkerComponent)iterator.next();
                try
                {
                    if (component is worker)
                    {
                        if (component.Description == "Manager")
                        {
                            AIWorkers.Append(component.Print());
                        }
                    }
                    else
                    {
                        Client client = new Client(component);
                        AIWorkers.Append(client.PrintManagerWorker());
                    }
                }
                catch (UnsupportedOperationException e)
                {
                }
                //    while (iterator.hasNext())
                //{
                //    WorkerComponent component = (WorkerComponent)iterator.next();
                //    try
                //    {
                //        if (component is worker)
                //        {
                //            AIWorkers.Append(component.Print());
                //        }
                //        else
                //        {
                //            foreach (WorkerComponent item in component.GetWorker())
                //            {

                //                if (item is worker)
                //                {
                //                    if (item.Description == "Manager")
                //                    {
                //                        AIWorkers.Append(item.Print());
                //                    }
                //                }
                //                else
                //                {
                //                    Client client = new Client(item);
                //                    AIWorkers.Append(client.PrintManagerWorker().ToString());
                //                }
                //            }
                //        }
                //    }
                //    catch (UnsupportedOperationException e)
                //    {
                //    }
            }
            return AIWorkers.ToString();
        }
        public string PrintSoftwareEnWorker()
        {
            StringBuilder AIWorkers = new StringBuilder();
            IIterator iterator = allWorkerField.CreateIterator();
            while (iterator.hasNext())
            {
                WorkerComponent component = (WorkerComponent)iterator.next();
                try
                {
                    if (component is worker)
                    {
                        if (component.Description == "SoftwareEn")
                        {
                            AIWorkers.Append(component.Print());
                        }
                    }
                    else
                    {
                        Client client = new Client(component);
                        AIWorkers.Append(client.PrintSoftwareEnWorker());
                    }
                }
                catch (UnsupportedOperationException e)
                {
                }
                //while (iterator.hasNext())
                //{
                //    WorkerComponent component = (WorkerComponent)iterator.next();
                //    try
                //    {
                //        if (component is worker)
                //        {
                //            AIWorkers.Append(component.Print());
                //        }
                //        else
                //        {
                //            foreach (WorkerComponent item in component.GetWorker())
                //            {

                //                if (item is worker)
                //                {
                //                    if (item.Description == "SoftwareEn")
                //                    {
                //                        AIWorkers.Append(item.Print());
                //                    }
                //                }
                //                else
                //                {
                //                    Client client = new Client(item);
                //                    AIWorkers.Append(client.PrintSoftwareEnWorker().ToString());
                //                }
                //            }
                //        }
                //    }
                //    catch (UnsupportedOperationException e)
                //    {
                //    }
            }
            return AIWorkers.ToString();
        }
    }
}
