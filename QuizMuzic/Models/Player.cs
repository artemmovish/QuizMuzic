﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMuzic.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Score = 0;
        }
    }
}
