using System;

namespace AuctionClass
{
    public class Client
    {
        public string Name { get; }
        public Auction Auction { get; }

        public Interessada(string name, Auction auction)
        {
            Name = name;
            Auction = auction;
        }
    }
}
