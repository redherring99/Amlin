using DJAmlin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DJAmlin.Modules
{
    public interface IRockGenerator
    {
        string Generate();

        Winner CalculateWinner(string choice1, string choice2);
    }

    public class RockGenerator : IRockGenerator
    {
        #region Properties/Members
        Random rnd;
        #endregion

        #region Constructor

        public RockGenerator()
        {
            rnd = new Random(DateTime.Now.Millisecond); // Try to ensure some entropy
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Generate Random Rock/Paper/Scissors string
        /// </summary>
        /// <returns></returns>
        public string Generate()
        {
            var theRocks = new List<string>();
            theRocks.Add(Definitions.Rock);
            theRocks.Add(Definitions.Paper);
            theRocks.Add(Definitions.Scissors);

            var res = theRocks[rnd.Next(0, 3)];

            return res;
        }
        /// <summary>
        /// Calculate who is the winner or draw
        /// 
        /// ***  Prob some cleaner way of doing this via LINQ ***
        /// 
        /// </summary>
        /// <param name="choice1"></param>
        /// <param name="choice2"></param>
        /// <returns></returns>
        public Winner CalculateWinner(string choice1, string choice2)
        {
            Winner result = Winner.Draw;

            if (choice1 == choice2) return Winner.Draw;
            switch (choice1)
            {
                case Definitions.Rock:
                    switch (choice2)
                    {
                        case Definitions.Paper:
                            result = Winner.Player2;
                            break;
                        case Definitions.Scissors:
                            result = Winner.Player1;
                            break;
                    }
                    break;
                case Definitions.Paper:
                    switch (choice2)
                    {
                        case Definitions.Rock:
                            result = Winner.Player1;
                            break;
                        case Definitions.Scissors:
                            result = Winner.Player2;
                            break;
                    }
                    break;

                case Definitions.Scissors:
                    switch (choice2)
                    {
                        case Definitions.Rock:
                            result = Winner.Player2;
                            break;
                        case Definitions.Paper:
                            result = Winner.Player1;
                            break;
                    }
                    break;
            }

            return result;
        }
        #endregion;
    }
}
