using System.Linq;
using System.Collections.Generic;
using System;

namespace AuctionClass
{
    public class Auction
    {
        private IList<Bid> _bids;
        private IEnumerable<Bid> Bids => _bids;
        public string Piece { get; set; }
        public Bid Winner { get; private set; }

        public Leilao(string piece)
        {
            Piece = piece;
            _bids = new List<Bid>();
        }

        public void ReceiveBid(Client client, double value)
        {
            _bids.Add(new Bid(client, value));
        }

        public void End()
        {
            Winner = Bids.OrderBy(x => x.Valor).Last();
        }
    }
}
