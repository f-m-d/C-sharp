using System;

namespace Player
{
    public class Player
    {
        public string Name { get; set; }

        private int money;


        // ALL PLAYERS CAN SEE YOUR MONEY
        public int GetMoney()
        {
            return money;
        }

        // ONLY IN-GAME EVENTS CAN CHANGE YOUR MONEY VALUE
        private void SetMoney(int value)
        {
            money = value;
        }

        //CONSTRUCTORS
        public Player(string name, int money)
        {
            this.Name = name;
            this.SetMoney(money);
        }

    }
}
