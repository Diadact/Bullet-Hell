using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace PlayerInput
{
   class PlayerInput
    {
        GamePadState pad;
        public enum Players { player1, player2, player3, player4 }

       //Constructor
        public PlayerInput(uint Index)
        {
            switch(Index)
            {
                case (uint)Players.player1 :
                    pad = GamePad.GetState(PlayerIndex.One);
                    break;
                case (uint)Players.player2 :
                    pad = GamePad.GetState(PlayerIndex.Two);
                    break;
                case (uint)Players.player3 :
                    pad = GamePad.GetState(PlayerIndex.Three);
                    break;
                case (uint)Players.player4 :
                    pad = GamePad.GetState(PlayerIndex.Four);
                    break;
                default :
                    pad = GamePad.GetState(PlayerIndex.One);
                    break;
            }
        }
     
        public GamePadState Update()
        {
            return pad;
        }
    }
}
