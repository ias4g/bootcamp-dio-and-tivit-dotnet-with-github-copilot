using chatbot_dotnet_mensagem_inteligente.Model;

Console.Write("Insira sua saudação: ");
string entrada = Console.ReadLine();

Mensagem mensagem = new Mensagem(entrada);

string saudacao = mensagem.Responder();

Console.WriteLine(saudacao);