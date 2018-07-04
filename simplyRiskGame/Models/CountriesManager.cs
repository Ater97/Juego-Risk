﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simplyRiskGame.Models
{
    public class CountriesManager
    {
        public Dictionary<int, Country> Countries = new Dictionary<int, Country>();
        public void FillMap()
        {   //North America
            Countries.Add(1, new Country("Alaska", 1, new List<int> { 6, 2, 32 }));
            Countries.Add(2, new Country("Alberta", 2, new List<int> { 1, 6, 7, 9 }));
            Countries.Add(3, new Country("México, América Central y el Caribe", 3, new List<int> { 9, 4, 13 }));
            Countries.Add(4, new Country("Estados Unidos del Este, compuesta por el Noreste y el Sudeste de Estados Unidos", 4, new List<int> { 3, 7, 8, 9 }));
            Countries.Add(5, new Country("Groenlandia", 5, new List<int> { 6, 7, 8, 21 }));
            Countries.Add(6, new Country("Territorios del Noroeste", 6, new List<int> { 1, 2, 7, 5 }));
            Countries.Add(7, new Country("Ontario", 7, new List<int> { 6, 2, 9, 4, 8, 5 }));
            Countries.Add(8, new Country("Quebec", 8, new List<int> { 5, 7, 4 }));
            Countries.Add(9, new Country("Estados Unidos del Oeste", 9, new List<int> { 2, 7, 4, 3 }));
            //South America
            Countries.Add(10, new Country("Argentina", 10, new List<int> { 11, 12 }));
            Countries.Add(11, new Country("Brasil", 11, new List<int> { 13, 12, 18, 10 }));
            Countries.Add(12, new Country("Perú", 12, new List<int> { 13, 11, 10 }));
            Countries.Add(13, new Country("Venezuela ", 13, new List<int> { 4, 11, 12 }));
            //Africa
            Countries.Add(14, new Country("Congo", 14, new List<int> { 18, 15, 19 }));
            Countries.Add(15, new Country("África Oriental ", 15, new List<int> { 33, 17, 19, 14, 18, 16 }));
            Countries.Add(16, new Country("Egipto", 16, new List<int> { 33, 15, 18, 24 }));
            Countries.Add(17, new Country("Madagascar", 17, new List<int> { 19, 15 }));
            Countries.Add(18, new Country("África del Norte", 18, new List<int> { 24, 26, 11, 14, 16, 15 }));
            Countries.Add(19, new Country("Sudáfrica", 19, new List<int> { 14, 15, 17 }));
            //Europe
            Countries.Add(20, new Country("Gran Bretaña", 20, new List<int> { 21, 23, 22, 26 }));
            Countries.Add(21, new Country("Islandia", 21, new List<int> { 5, 23, 20 }));
            Countries.Add(22, new Country("Europa del Norte", 22, new List<int> { 23, 25, 24, 20, 26 }));
            Countries.Add(23, new Country("Escandinavia", 23, new List<int> { 25, 22, 20, 21 }));
            Countries.Add(24, new Country("Europa del Sur", 24, new List<int> { 16, 18, 22, 25, 26, 33 }));
            Countries.Add(25, new Country("Ucrania", 25, new List<int> { 24, 23, 22, 37, 27, 33 }));
            Countries.Add(26, new Country("Europa Occidental", 26, new List<int> { 24, 20, 22, 18 }));
            //Asia
            Countries.Add(27, new Country("Afganistán", 27, new List<int> { 25, 37, 28, 29, 33 }));
            Countries.Add(28, new Country("China", 28, new List<int> { 35, 29, 27, 37, 36, 34 }));
            Countries.Add(29, new Country("India", 29, new List<int> { 35, 28, 27, 33 }));
            Countries.Add(30, new Country("Irkutsk", 30, new List<int> { 34, 32, 38, 36 }));
            Countries.Add(31, new Country("Japón", 31, new List<int> { 34, 32 }));
            Countries.Add(32, new Country("Kamchatka", 32, new List<int> { 1, 38, 30, 34, 31 }));
            Countries.Add(33, new Country("Oriente Medio", 33, new List<int> { 24, 25, 16, 15, 29, 27 }));
            Countries.Add(34, new Country("Mongolia", 34, new List<int> { 28, 31, 32, 30, 36 }));
            Countries.Add(35, new Country("Siam", 35, new List<int> { 40, 28, 29 }));
            Countries.Add(36, new Country("Siberia", 36, new List<int> { 28, 34, 30, 38, 37 }));
            Countries.Add(37, new Country("Ural", 37, new List<int> { 25, 36, 28, 27 }));
            Countries.Add(38, new Country("Yakutsk", 38, new List<int> { 36, 30, 32 }));
            //Australia
            Countries.Add(39, new Country("Australia Oriental, compuesta por Queensland y por la Nueva Gales del Sur", 39, new List<int> { 41, 42 }));
            Countries.Add(40, new Country("Indonesia", 40, new List<int> { 35, 41, 42 }));
            Countries.Add(41, new Country("Nueva Guinea", 41, new List<int> { 39, 40, 42 }));
            Countries.Add(42, new Country("Australia Occidental", 42, new List<int> { 40, 41, 39 }));

            for (int i = 1; i <= Countries.Count(); i++)
            {
                Countries[i].setNeighbors(setNeighborsCM(Countries[i]));
            }
        }
        // List<int>
        public List<Country> setNeighborsCM(Country C)
        {
            List<Country> t = new List<Country>();
            for (int i = 0; i < C.Neighborsint.Count(); i++)
            {
                t.Add(Countries[C.Neighborsint[i]]);
            }
            return t;
        }

        public List<int> getPlayerCountries(int player) // number of the player who owns that country, 0 if its neutral 
        {
            List<int> t = new List<int>(); //countries ids list
            for (int i = 1; i <= Countries.Count(); i++)
            {
                if (Countries[i].Owner == player)
                    t.Add(i);
            }
            return t;
        }

    }
}