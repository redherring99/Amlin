using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DJAmlin.Models
{
    public enum Winner
    {
        Player1,
        Player2,
        Draw
    }

    /// <summary>
    /// Holds results of a game
    /// </summary>
    public class GameResult
    {
        public string Player1Choice { get; set; }
        public string Player2Choice { get; set; }

        public Winner WinningPlayer { get; set; }

    }
}
