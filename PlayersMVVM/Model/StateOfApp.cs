using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlayersMVVM
{
    public class StateOfApp
    {
        private static string pathXML = @"../../../PlayersMVVM/Resources/PlayersMVVM.xml";
        private static string pathTxt = @"../../../PlayersMVVM/Resources/PlayersMVVM.txt";
        /// <param name="allPlayers"></param>
        public static void Save(ObservableCollection<PlayerViewModel> allPlayers)
        {
            string playerlist = string.Empty;
            foreach(PlayerViewModel player in allPlayers)
            {
                playerlist += $"{player.FirstName} ; {player.LastName} ; {player.Age} ; {player.Weight} {Environment.NewLine}";

            }
            File.WriteAllText(pathTxt, playerlist.Trim());

            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<PlayerViewModel>));
            using (StreamWriter wr = new StreamWriter(pathXML))
            {
                xs.Serialize(wr, allPlayers);
            }
        }

        private static PlayerViewModel stringToPlayerViewModel(string playerTxt)
        {
            string[] info = playerTxt.Split(';');
            if (info.Length != 4)
            {
                return new PlayerViewModel();
            }

            string firstname = info[0].Trim();
            string lastName = info[1].Trim();
            int age = 0;
            double weight = 0;

            try
            {
                age = int.Parse(info[2].Trim());
                weight = Double.Parse(info[3].Trim());
            }
            catch { }

            return new PlayerViewModel(firstname, lastName, weight, age);
        }

        public static ObservableCollection<PlayerViewModel> LoadFromFile()
        {
            ObservableCollection<PlayerViewModel> xplayers = new ObservableCollection<PlayerViewModel>();
            string dataFromFile = File.ReadAllText(pathTxt).Trim();

            string[] txtPlayers = dataFromFile.Split('\n');

            foreach (string txtPlayer in txtPlayers)
            {
                xplayers.Add(stringToPlayerViewModel(txtPlayer));
            }

            return xplayers;
        }
    }

}

  



