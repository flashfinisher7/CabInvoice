﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvioceGenerater
{
    public class Ride
    {
        public double distance;
        public int time;
        /// <summary>
        /// Parameter Constructor For Setting Data.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
