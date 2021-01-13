using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NoughtsCrossesASPNET.Models
{
    public class Game
    {
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public bool IsOver { get; set; }
        public List<int> BoardState { get; set; }
        public int? GameStreak { get; set; }
    }
}
