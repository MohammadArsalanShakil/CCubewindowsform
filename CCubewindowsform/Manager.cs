using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLogic
{
    public class Manager:Person
    {
        double salary;
        DateTime dutyTime;
        public FileHandler playerfile = new FileHandler();
        ArrayList gamelist = new ArrayList();
        static int gameID = 0;
        Game temp;
        bool wait = true;
        ArrayList playerwaitinglist = new ArrayList();

        ArrayList PlayerList;

        public string DisplayAllPlayers()
        {
            string getData = "";
            //InputOutputHandler.DisplayAllPlayer(this.PlayerList);
            foreach (Player player in PlayerList)
                getData += (player.getData());
            return getData;
        }

        public void RegisterNewPlayer(Player newPlayer)
        {
            //Player newPlayer = InputOutputHandler.GetPlayerInfoFromUser();
            PlayerList.Add(newPlayer);
        }

        public void SearchPlayerInfobyCNIC()
        {
            Player player = new Player();
            string cnic = InputOutputHandler.GetPlayerCNIC();
            bool playerfound = false;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    break;
                }
            }
            if (playerfound)
                InputOutputHandler.displayPlayerInfo(player);
            else
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
            }
        }

        public bool SearchPlayerInfobyCNIC(string cnic,int check)
        {
            Player player = new Player();

            bool playerfound = false;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    break;
                }
            }
            if (playerfound)
                return true;
            else
            {
                return false;
            }
        }

        public string SearchPlayerInfobyCNIC(string cnic)
        {
            Player player = new Player();
            
            bool playerfound = false;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    break;
                }
            }
            if (playerfound)
                return player.CNIC;
            else
            {
                return "not found";
            }
        }

        public string SearchPlayerInfobyName(string name)
        {
            Player player = new Player();
            //string name = InputOutputHandler.getPlayerName();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.Name == name)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound)
            {
                return player.Name;
                //InputOutputHandler.displayPlayerInfo(player);
            }
            else
            {
                return "not found";
            }
        }

        public bool EditPlayerInfobyCNIC(bool edit,string cnic)//Getting bool if user wants to edit or delete
        {
            Player player = new Player();
            //string cnic = InputOutputHandler.GetPlayerCNIC();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound && edit)//If user selects to edit and the index is found in the AraryList then user will be taken to editPlayer Function
                return true;
            else if (!edit && playerfound)//If he wish to delete the player will be deleted from the record
            {
                PlayerList.RemoveAt(indexofplayer);
                playerfile.Writeback();
                return true;
            }
            else if (!playerfound)
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
                return false;
            }
            return false;
        }


        public bool EditPlayerInfobyName(bool edit,string name)
        {
            Player player = new Player();
            //string name = InputOutputHandler.getPlayerName();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.Name == name)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound && edit)//If user selects to edit and the index is found in the AraryList then user will be taken to editPlayer Function
                return true;
            else if (!edit && playerfound)//If he wish to delete the player will be deleted from the record
            {
                PlayerList.RemoveAt(indexofplayer);
                playerfile.Writeback();
                return true;
            }
            else if (!playerfound)
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
                return false;
            }
            return false;
        }


        public bool EditPlayerInfobyCNIC(bool edit, string cnic, string newcnic, string newname)//Getting bool if user wants to edit or delete
        {
            Player player = new Player();
            //string cnic = InputOutputHandler.GetPlayerCNIC();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.CNIC == cnic)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound && edit)//If user selects to edit and the index is found in the AraryList then user will be taken to editPlayer Function
            {
                player.CNIC = newcnic;
                player.Name = newname;
                return true;
            }
            else if (!edit && playerfound)//If he wish to delete the player will be deleted from the record
            {
                PlayerList.RemoveAt(indexofplayer);
                playerfile.Writeback();
                return true;
            }
            else if (!playerfound)
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
                return false;
            }
            return false;
        }


        public bool EditPlayerInfobyName(bool edit, string name, string newcnic, string newname)
        {
            Player player = new Player();
            //string name = InputOutputHandler.getPlayerName();
            bool playerfound = false;
            int indexofplayer = -1;
            for (int index = 0; index < PlayerList.Count; index++)
            {
                player = PlayerList[index] as Player;
                if (player.Name == name)
                {
                    playerfound = true;
                    indexofplayer = index;
                    break;
                }
            }
            if (playerfound && edit)//If user selects to edit and the index is found in the AraryList then user will be taken to editPlayer Function
            {
                player.CNIC = newcnic;
                player.Name = newname;
                return true;
            }
            else if (!edit && playerfound)//If he wish to delete the player will be deleted from the record
            {
                PlayerList.RemoveAt(indexofplayer);
                playerfile.Writeback();
                return true;
            }
            else if (!playerfound)
            {
                Player falseplayer = new Player
                {
                    CNIC = "not found"
                };
                InputOutputHandler.EditPlayer(falseplayer);
                return false;
            }
            return false;
        }
        public Manager()
        {
            PlayerList = playerfile.PlayerList;
        }
        public Manager(string cnic,string name,double salary,DateTime dutyTime):base(cnic,name)
        {
            this.salary = salary;
            this.dutyTime = dutyTime;
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }

        }

        public DateTime DutyTime
        {
            set { dutyTime = value; }
            get { return dutyTime; }

        }


        public override string getData()
        {
            string data = base.getData();
            data += "Salary :" + this.salary + "\n";
            data += "DutyTime :" + this.dutyTime.Hour + ":" + this.dutyTime.Minute + "\n";
            data += "------------------------------";
            return data;

        }
        ~Manager()
        {
            this.ExitApplication();
        }

        void ExitApplication()
        {
            playerfile.PlayerList = this.PlayerList;
            playerfile.Writeback();
        }

        public void Result(int id, sbyte result)
        {
            //int id = InputOutputHandler.getgameID();
            foreach (Game game in gamelist)
            {
                if (id == game.Gameid)
                {
                    game.Result = result;
                    game.Player1.TotalGamesPlayed++;
                    game.Player2.TotalGamesPlayed++;
                    if (game.Result == -1)
                    {
                        game.Player2.TotalGamesWon++;
                        game.Player1.TotalGamesLost++;
                    }
                    else if (game.Result == 1)
                    {
                        game.Player1.TotalGamesWon++;
                        game.Player2.TotalGamesLost++;
                    }
                    break;
                }
            }
        }

        public bool StartGamefor2(string p1cnic,string p1name,string p2cnic,string p2name)
        {
            Table gametable = new Table();
            gameID++;
            Player player1 = new Player();
            player1.CNIC = p1cnic;
            player1.Name = p1name;
            Player player2 = new Player();
            player2.CNIC = p1cnic;
            player2.Name = p1name;
            string player1datamatch = SearchPlayerInfobyCNIC(player1.CNIC);
            string player2datamatch = SearchPlayerInfobyCNIC(player2.CNIC);
            if (player1datamatch == "not found")
                RegisterNewPlayerduringgame(player1);
            if (player2datamatch == "not found")
                RegisterNewPlayerduringgame(player2);
            Game game = new Game(gameID, player1, player2);
            if (gamelist.Count < 10)
            {
                    if (gametable.Player1 == false && gametable.Player2 == false)
                    {
                        gametable.Game = game;
                        gametable.Player1 = true;
                        gametable.Player2 = true;
                        gametable.Tablefree = false;
                        wait = false;
                        gamelist.Add(gametable);
                    }
                    else if (gametable.Player1 == true && gametable.Player2 == false)
                    {
                        temp = gametable.Game;
                        gametable.Game = game;
                        gametable.Player1 = true;
                        gametable.Player2 = true;
                        gametable.Tablefree = false;
                        wait = true;
                        gamelist.Add(gametable);
                    }
                    else if (gametable.Player1 == false && gametable.Player2 == true)
                    {
                        temp = gametable.Game;
                        gametable.Game = game;
                        gametable.Player1 = true;
                        gametable.Player2 = true;
                        gametable.Tablefree = false;
                        wait = true;
                        gamelist.Add(gametable);
                    }
                    else if (gametable.Player1 == true && gametable.Player2 == true)
                    {
                        temp = game;
                        wait = true;
                    }
            }
            if (wait)
            {
                Waitinglist();
                return false;
                //InputOutputHandler.Waitmessage();
            }
            return true;
        }

        void StartGameforrandom2(Game game)
        {
            Table gametable = new Table();
            gameID++;
            for (int i = 0; i < 9; i++)
            {
                if (gametable.tablecheck() == true)
                {
                    if (gametable.player1check() == false && gametable.player2check() == false)
                    {
                        gametable.Game = game;
                        gametable.Player1 = true;
                        if (gametable.Game.Player2.CNIC != "0")
                            gametable.Player2 = true;
                        else
                            gametable.Player2 = false;
                        gametable.Tablefree = false;
                        wait = false;
                    }
                    else if (gametable.player1check() == true && gametable.player2check() == false)
                    {

                        temp = gametable.Game;
                        gametable.Game = game;
                        if (gametable.Game.Player2.CNIC != "0")
                            gametable.Player2 = true;
                        else
                            gametable.Player2 = false;
                        gametable.Tablefree = false;
                        wait = true;
                    }
                }
                else
                {
                    while (i < 9 && gametable.tablecheck() != true)
                        i++;
                }
            }
            if (wait)
                Waitinglist();
            else
                InputOutputHandler.Waitmessage();
        }

        public void Waitinglist()
        {
            playerwaitinglist.Add(temp);
        }

        public void StartGamefor1(string cnic, string name)
        {
            gameID++;
            Player player = new Player();
            player.CNIC = cnic;
            player.Name = name;
            string playerdatamatch = SearchPlayerInfobyCNIC(cnic);
            if (playerdatamatch == cnic)
                RegisterNewPlayerduringgame(player);
            Game game = new Game();
            if (playerwaitinglist.Count != 0)
            {
                game = PlayerList[0] as Game;
                playerwaitinglist.RemoveAt(0);
                game.Addplayer2(player);
            }
            else
            {
                Player playerdummy = new Player { CNIC = "0" };
                game.Gameid = gameID;
                game.Player1 = player;
                game.Player2 = playerdummy;
            }
            StartGameforrandom2(game);
        }

        public void RegisterNewPlayerduringgame(Player player)
        {
            //Player newPlayer = InputOutputHandler.GetPlayerInfoFromUser();
            PlayerList.Add(player);
        }
    }//end class
}//end namespace
