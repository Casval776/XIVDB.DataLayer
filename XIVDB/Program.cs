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
            XIVDBClient client = XIVDBClient.Instance;
            string searchTerm = " gae bolg ";
            foreach (Enums.SearchType x in Enum.GetValues(typeof(Enums.SearchType)))
            {
                client.XIVDBQuery(x, searchTerm);
            }
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
