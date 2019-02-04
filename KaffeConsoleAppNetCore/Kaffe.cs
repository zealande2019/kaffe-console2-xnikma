﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    /// <summary>
    /// Abstract klasse som alle kaffer nedarver fra
    /// </summary>
    public abstract class Kaffe
    {
        /// <summary>
        /// abstract metode der skal angive hvad kaffen koster.
        /// Denne metode skal overrides i den klasse som arver fra klassen Kaffe
        /// </summary>
        /// <returns></returns>
        public abstract int Pris();
        
        /// <summary>
        /// Angiver hvor stærk kaffe er. 
        /// Sættes default til "stærk"
        /// </summary>
        /// <returns></returns>
        public virtual string Styrke()
        {
            return "stærk";
        }

        public virtual string Navn()
        {
            return "Kaffe";
        }

        /// <summary>
        /// rabat der gives på kaffen
        /// </summary>
        public int Rabat { get; set; }



        /// <summary>
        /// default ctor
        /// </summary>
        public Kaffe()
        {
            //this.Rabat = 0;
            Console.WriteLine("en " + Navn() + " til " + Pris() + ",- kr");
        }

        public Kaffe(int rabat)
        {
            this.Rabat = rabat;
        }


    }
}
