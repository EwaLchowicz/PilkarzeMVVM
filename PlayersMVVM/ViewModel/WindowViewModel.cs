using PlayersMVVM.AddPlayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersMVVM
{
    public class WindowViewModel : BaseViewModel
    {
        private readonly List<int> rangeOfAge;
        private PlayerViewModel displayedPlayer;
        private PlayerViewModel selectedPlayer;
        private PlayerViewModel newPlayer;
        private ObservableCollection<PlayerViewModel> listOfPlayers;
        private RelayCommand save;
        private RelayCommand deletePlayer;
        private RelayCommand modifyPlayer;
        private RelayCommand addPlayer;

        public WindowViewModel()
        {
            rangeOfAge = new List<int>();
            for (int i = 15; i <= 55; i++)
                rangeOfAge.Add(i);
            listOfPlayers = StateOfApp.LoadFromFile();
            if (listOfPlayers.Count > 0)
            {
                displayedPlayer = new PlayerViewModel(
                    listOfPlayers[0].FirstName, listOfPlayers[0].LastName, listOfPlayers[0].Weight, listOfPlayers[0].Age);
            } 
            else
            {
                displayedPlayer = new PlayerViewModel();
            }
            newPlayer = new PlayerViewModel();
        }
        public List<int> RangeOfAge
        {
            get
            { return rangeOfAge; }
        }
        public PlayerViewModel DisplayedPlayer
        {
            get { return displayedPlayer; }
        }
        public PlayerViewModel SelectedPlayer
        {
            get { return selectedPlayer; }
            set
            {
                if (value != null)
                {
                    selectedPlayer = value;
                    displayedPlayer.FirstName = value.FirstName;
                    displayedPlayer.LastName = value.LastName;
                    displayedPlayer.Age = value.Age;
                    displayedPlayer.Weight = value.Weight;
                }
            }
        }


        public PlayerViewModel NewPlayer
        {
            get { return newPlayer; }
        }

        public ObservableCollection<PlayerViewModel> ListOfPlayers
        {
            get { return listOfPlayers; }
            set { listOfPlayers = value; onPropertyChanged(nameof(ListOfPlayers)); }
        }

        public RelayCommand Save
        {
            get
            {
                if (save == null)
                    save= new RelayCommand(arg => { StateOfApp.Save(listOfPlayers); }, arg => true);
                return save;
            }
        }
        public RelayCommand DeletePlayer
        {
            get
            {
                if (deletePlayer == null)
                    deletePlayer= new RelayCommand(arg => { listOfPlayers.Remove(selectedPlayer); }, arg => true);
                return deletePlayer;
            }
        }

        public RelayCommand ModifyPlayer
        {
            get
            {
                if (modifyPlayer == null)
                    modifyPlayer = new RelayCommand(arg=>
                    {
                        if (selectedPlayer != null & !string.IsNullOrEmpty(displayedPlayer.FirstName) &
                            !string.IsNullOrEmpty(displayedPlayer.LastName))
                        {
                            selectedPlayer.FirstName = displayedPlayer.FirstName;
                            selectedPlayer.LastName = displayedPlayer.LastName;
                            selectedPlayer.Age = displayedPlayer.Age;
                            selectedPlayer.Weight = displayedPlayer.Weight;
                            selectedPlayer.Description = selectedPlayer.ToString();
                        }
                    }, arg => true);
                return modifyPlayer;
            }
        }

        public RelayCommand AddPlayer
        {
            get
            {
                if (addPlayer== null)
                    addPlayer = new RelayCommand(arg =>
                    {
                        WindowAddPlayer window = new WindowAddPlayer();
                        window.DataContext = this;
                        window.ShowDialog();
                        if (window.DialogResult == true)
                        {
                            if (newPlayer != null)
                            {
                                listOfPlayers.Add(new PlayerViewModel(
                                    newPlayer.FirstName, newPlayer.LastName, newPlayer.Weight, newPlayer.Age));
                            }
                        }
                    }, arg => true);
                return addPlayer;
            }
        }
    }
}
