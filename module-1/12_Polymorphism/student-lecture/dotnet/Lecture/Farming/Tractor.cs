﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : IMakesNoise
    {
        public void PlowField()
        {

        }

        public string Name
        {
            get
            {
                return "Tractorzilla";
            }
        }
        public string MakeSoundOnce()
        {
            return "Vvvvvvrrooooom";
        }

        public string MakeSoundTwice()
        {
            return "VROOOOOOOM";
        }




}
}
