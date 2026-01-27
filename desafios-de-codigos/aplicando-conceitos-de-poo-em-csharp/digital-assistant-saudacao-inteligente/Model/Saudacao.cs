using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Classe que deve gerar a saudação personalizada
namespace digital_assistant_saudacao_inteligente.Model
{
    public class Saudacao
    {
        private readonly string nomeCliente;

        public Saudacao(string nomeCliente)
        {
            this.nomeCliente = nomeCliente;
        }

        public string ObterMensagem()
        {
            // TODO: Implemente a lógica para criar uma saudação personalizada usando o nome armazenado.
            // Dica: utilize interpolação de strings para incluir o nome na mensagem final.
            return $"Bem-vindo(a), {nomeCliente}!"; // Retorne a mensagem formatada corretamente aqui
        }
    }
}