using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_dotnet_mensagem_inteligente.Model
{
    // Classe responsável por armazenar e responder mensagens de saudação
    public class Mensagem
    {
        private string saudacao;

        public Mensagem(string saudacao)
        {
            this.saudacao = saudacao;
        }

        // TODO: Modifique este método para personalizar a resposta do bot de acordo com critérios fornecidos pelo enunciado
        // Dica: avalie o conteúdo da saudação para determinar a resposta adequada
        public string Responder()
        {
            // Atualmente, apenas retorna um padrão fixo. 
            // O aluno deve alterar para adaptar às regras do desafio.
            return $"Bot: Obrigado pela mensagem: {saudacao}";
        }
    }
}