using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.Models
{
    internal class JokenpoUser
    {
        public string nome { get; set; }
        public int pontuacao { get; set; }
        public Opcao opcaoEscolhida { get; set; }
        
        //Criar o metodo Jogar do bot 
        //O Método jogar gera um número aleatório entre 0 e 2, e o transforma no enum equivalente
        public void jogar()
        {
            Opcao opcao = (Opcao)new Random().Next(3);
        }
    }
}
