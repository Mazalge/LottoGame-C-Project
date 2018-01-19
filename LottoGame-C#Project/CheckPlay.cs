using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CheckPlay
    {
        ComputerCard ComputerCard = new ComputerCard();
        UserCard UserCard = new UserCard();


        public CheckPlay(ComputerCard _ComputerCard, UserCard _UserCard)
        {
            ComputerCard = _ComputerCard;
            UserCard = _UserCard;
        }
        static int correctnums = 0;

        public int ComparePlay()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    if (ComputerCard.GatarComputerCard(j) == UserCard.GatArUserCarb(i))
                    {
                        correctnums++;
                    }
                }
            }
            return correctnums;
        }
    }
}
