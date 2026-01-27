using System.Text;
using digital_assistant_saudacao_inteligente.Model;

Console.Write("Insira seu nome: ");
string nome = Console.ReadLine();

Saudacao s = new Saudacao(nome);

string saudacao = s.ObterMensagem();

Console.WriteLine(saudacao);