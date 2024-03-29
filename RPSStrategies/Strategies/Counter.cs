﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSStrategies.Strategies
{
    internal class Counter : AbstractStrategy
    {
        Hand OpponentsLastPick = Hand.NOT_PICKED;

        public override void Pick()
        {
            if (OpponentsLastPick == Hand.NOT_PICKED)
            {
                Hand = GetRandomHand();
                return;
            }

            Hand = GetCounter(OpponentsLastPick);
        }

        public override void Play(Hand opponentHand)
        {
            OpponentsLastPick = opponentHand;
        }

        public override void Reset()
        {
            OpponentsLastPick = Hand.NOT_PICKED;
        }
    }
}
