using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ComputerCard
    {
        int[] arComputerCard;

        public ComputerCard()
        {
            arComputerCard = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        public bool ExistsNum(int num)
        {
            bool ifExist = false;
            for (int i = 0; i < arComputerCard.Length; i++)
            {
                if (arComputerCard[i] == num)
                {
                    ifExist = true;
                    break;
                }
            }
            return ifExist;
        }

        public void GeterateValue()
        {
            Random num = new Random();
            for (int index = 0; index < 6;)
            {
                
                int randomNum = num.Next(1, 47);
                if (ExistsNum(randomNum) == false)
                {
                    arComputerCard[index] = randomNum;
                    index++;
                }
            }
        }

        public int GatarComputerCard(int num)
        {
            return arComputerCard[num];
        }

    }
}
