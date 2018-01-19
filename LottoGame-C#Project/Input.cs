using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Input
    {
        UserCard card = new UserCard();

        public Input(UserCard _card)
        {
            card = _card;
        }

        public void GatUserValues()
        {
            int validcounternum = 6;
            for (int index = 0; index < 6; index++)
            {
                Console.WriteLine("Input {0} Number between 1-46" , validcounternum);
                string str = Console.ReadLine();
                int UserNum;
                bool valid = int.TryParse(str, out UserNum);
                if (valid)
                {
                    if (UserNum > 0 && UserNum < 47)
                    {
                        if (card.ExistsNum(UserNum)==false)
                        {
                            card.AddNum(UserNum);
                            validcounternum--;
                        }
                        else
                        {
                            Console.WriteLine("the number already exist");
                            index--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error - the number should be between 1-46");
                        index--;
                    }
                }
                else
                {
                    Console.WriteLine("the inpot is not valid");
                    index--;
                }
            }
            
        }
    }
}
