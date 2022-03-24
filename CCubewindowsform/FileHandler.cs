﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgrammingLogic
{
    public class FileHandler
    {
        

        ArrayList playerList = new ArrayList();
        //ArrayList managerList = new ArrayList();
        
        public ArrayList PlayerList
        {
            get { return this.playerList; }
            set { playerList = value; }
        }

        //public ArrayList Gamelist { get => gamelist; set => gamelist = value; }

        //public ArrayList ManagerList { get => managerList; set => managerList = value; }

        public void ReadAllPlayer()
        {
            StreamReader reader = new StreamReader("Player.txt",true);
            while (!reader.EndOfStream)
            {
                Player player = new Player
                {
                    CNIC = reader.ReadLine(),
                    Name = reader.ReadLine(),
                    TotalGamesPlayed = uint.Parse(reader.ReadLine()),
                    TotalGamesWon = uint.Parse(reader.ReadLine()),
                    TotalGamesLost = uint.Parse(reader.ReadLine())
                };

                playerList.Add(player);
            }
            reader.Close();
        }

        public FileHandler()
        {
            this.ReadAllPlayer();
        }

        public void StoreAllPLayersBackToFile()
        {
            StreamWriter playerFileWriter = new StreamWriter("Player.txt");
            foreach (Player player in playerList)
            {
                playerFileWriter.WriteLine(player.CNIC);
                playerFileWriter.WriteLine(player.Name);
                playerFileWriter.WriteLine(player.TotalGamesPlayed);
                playerFileWriter.WriteLine(player.TotalGamesWon);
                playerFileWriter.WriteLine(player.TotalGamesLost);
            }
            playerFileWriter.Close();
        }

        public void Writeback()
        {
            this.StoreAllPLayersBackToFile();
        }

        

        ~FileHandler()
        {
            this.StoreAllPLayersBackToFile();
        }

        

        public void PlayerStatsupdate(Player player)
        {
            string cnic = player.CNIC;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    player.TotalGamesPlayed++;
                    
                }
            }
        }

        public Player SearchPlayerInfobyCNIC(string cnic)
        {
            Player player = new Player();
            Player temp = new Player();
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    temp.CNIC = player.CNIC;
                    temp.Name = player.Name;
                    temp.TotalGamesPlayed = player.TotalGamesPlayed;
                    temp.TotalGamesWon = player.TotalGamesWon;
                    temp.TotalGamesLost = player.TotalGamesLost;
                }
            }
            return temp;
        }


    }
}
