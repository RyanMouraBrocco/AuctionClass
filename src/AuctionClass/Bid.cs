using System;

namespace AuctionClass
{
    public class Bid
    {
        public Client Client { get; }
        public double Valor { get; }

        public Bid(Client client, double value)
        {
            Client = client;
            Value = value;
        }
    }
}
