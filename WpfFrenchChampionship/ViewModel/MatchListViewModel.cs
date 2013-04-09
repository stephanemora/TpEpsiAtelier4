using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoccerRankingLib;
using System.Collections.ObjectModel;

namespace WpfFrenchChampionship.ViewModel
{
    class MatchListViewModel : ViewModel
    {
        private ObservableCollection<Match> matches = new ObservableCollection<Match>();

        public ObservableCollection<Match> Matches
        {
            get { return this.matches; }
        }

        public MatchListViewModel(Ranking ranking)
        {
            throw new NotImplementedException();  
        }

        public void ranking_NewMatchRegistered(object sender, SoccerRankingLib.Ranking.MatchRegistrationEventArgs e)
        {
            throw new NotImplementedException();   
        }


    }

    


}
