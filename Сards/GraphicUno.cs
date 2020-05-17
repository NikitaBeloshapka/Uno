using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сards
{
    class GraphicUno : Uno
    {
        public GraphicUno(CardSet commonDeck, Player player1, Player player2, Panel player1Deck, Panel player2Deck, Panel otherDeck) : base(commonDeck, player1, player2)
        {
            Player1.Cards = new GraphicCardSet(player1Deck);
            Player2.Cards = new GraphicCardSet(player2Deck);

        }
    }
}
