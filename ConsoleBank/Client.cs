using System;

namespace SpaceClient
{
    class Client
    {
        private int Id;
        private string Name;
        private string Date;

        public int ClientId
        {
            get { return Id; }
            set { Id = value; }
        }

        public string ClientName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string StartDate
        {
            get { return Date; }
            set { Date = value; }
        }

        public Client(int id, string name, string date)
        {
            this.ClientId = id;
            this.ClientName = name;
            this.StartDate = date;
        }
    }
}