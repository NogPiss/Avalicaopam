using CommunityToolkit.Mvvm.ComponentModel;
using JoKenPo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.ViewModels
{
    public partial class JoKenPoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string playername;

        [ObservableProperty]
        private int playerscore;

        [ObservableProperty]
        private string playerImage;
        
        [ObservableProperty]
        private string botImage;
        
        [ObservableProperty]
        private string result;
        
        [ObservableProperty]
        private Opcao playerChoice;

        JokenpoUser player = new JokenpoUser();

        public void Play()
        {
            JokenpoUser bot = new JokenpoUser();
            bot.jogar();
            player.opcaoEscolhida = playerChoice;
            if(bot.opcaoEscolhida == player.opcaoEscolhida)
            {
                result = "Empate"; 
            }
        }
        public JoKenPoViewModel()
        {

        }
    }
}
