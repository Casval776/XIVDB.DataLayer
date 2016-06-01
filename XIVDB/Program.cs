//--------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//--------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVDB
{
    class Program
    {
        public Program()
        {
            XIVDBClient client = new XIVDBClient();
            client.XIVDBQuery(Enums.SearchType.Text, " excalibur zenith ");
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
