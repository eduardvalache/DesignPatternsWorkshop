using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopExample._2._AntiPatterns
{
    public class AnemicModel
    {
        public void Run()
        {
            var client = new Client();

            var clientDisplayName = client.FirstName + ", " + client.LastName;

            client.Status = "Awaiting";

            if (clientDisplayName.StartsWith("A"))
            {
                client.Order = 1;
            }
            
            // ...
        }
    }

    public class Client
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Status { get; set; }

        public int Order { get; set; }
    }
}
