using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Controllers
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        // Constructor
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Princess Carolyn";
            CurrentPlayer.Gold = 999999;
        }
    }
}
