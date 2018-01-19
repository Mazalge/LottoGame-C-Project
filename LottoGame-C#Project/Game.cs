using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Game
    {
        public Game()
        {
            UserCard user = new UserCard();
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            user.NamePalyr = name;
            Input input = new Input(user);
            input.GatUserValues();
            ComputerCard card = new ComputerCard();
            card.GeterateValue();
            CheckPlay chek = new CheckPlay(card, user);
            Output.Write(chek.ComparePlay());
        }
    }
}
