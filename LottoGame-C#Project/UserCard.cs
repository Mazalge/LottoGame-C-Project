using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class UserCard
    {
        public string NamePalyr { get; set; }

        int[] arUserCarb;

        public int  GatArUserCarb(int num)
        {
            return arUserCarb[num];
        }


        static int raIndx;

        public UserCard()
        {
            arUserCarb = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        public bool ExistsNum(int num)
        {

            bool ifExist = false;
            for (int i = 0; i < arUserCarb.Length; i++)
            {
                if (arUserCarb[i] == num)
                {
                    ifExist = true;
                    break;
                }
            }
            return ifExist;
        }


        public void AddNum(int newNum)
        {

            if (raIndx < 6)
            {
                if (ExistsNum(newNum) == false)
                {
                    arUserCarb[raIndx] = newNum;
                    raIndx++;
                }
                else
                {
                    Console.WriteLine("The namber Exists");
                }

            }
            else
            {
                Console.WriteLine("User Card AREY IS FOLL");
            }
        }
    }
}
