using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using TeamGames;

namespace TeamGames
{
    public class GameFactory
    {
        public List<Game> gameList;
        StreamWriter writer;
        XmlSerializer serial;

        public String FilePath { get; set; }


        public void CreateGameList()
        {
            gameList = new List<Game>();
            Game G = new Game("Alabama", "Arkansas", 30, 42);
            gameList.Add(G);
            G = new Game("Florida", "Georgia", 35, 10);
            gameList.Add(G);
            G = new Game("Aurburn", "Kentucky", 21, 13);
            gameList.Add(G);
            G = new Game("Tennessee", "Texas", 23, 15);
            gameList.Add(G);
            G = new Game("Missouri", "California", 25, 17);
            gameList.Add(G);
            G = new Game("New York", "Boston", 16, 8);
            gameList.Add(G);

        }

        public Boolean SerializeGameList()
        {
            try
            {
                serial = new XmlSerializer(gameList.GetType());
                writer = new StreamWriter(@"..\..\game.xml");
                serial.Serialize(writer, gameList);
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }
}
