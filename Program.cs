using System;

namespace Exercicio_Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validpassword;
            int escolha;
            int counter = 0;
            string answer;
            
            string[] nome = new string [5];
            string[] Origem = new string [5];
            string[] Destino = new string [5];
            string[] data = new string [5];

            
            
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" Seja muito Bem Vindo !");
            Console.WriteLine("-------------------------------------------------------");
            

            do {
            
            Console.WriteLine();
            Console.WriteLine("Escolha a sua senha");
            Console.WriteLine();
            string senha = Console.ReadLine();
            validpassword = PerformLogin(senha);
            
            } while (!validpassword);

            Console.WriteLine();
            Console.WriteLine("Seja Muito Bem Vindo !");
            Console.WriteLine();

            bool PerformLogin(string senha) {

                if(senha == "123456") {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Senha Aceita");
                    Console.ResetColor();
                    return true;
                
                    } else {
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha Invalida");
                    Console.ResetColor();
                    return false; 
            
                    }
                }


            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine();
                Console.WriteLine("[1] Registrar passagem");
                Console.WriteLine("[2] Mostrar Viagens disponiveis");
                Console.WriteLine("[3] Sair");
                Console.WriteLine();
                Console.Write("Opção ");
                
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        
                        Console.WriteLine();
                        Console.WriteLine("Registro de Passageiro");
                        
                    do {

                            if (counter < 5) {

                            Console.WriteLine();
                            Console.WriteLine($"Digite o nome do {counter + 1} passageiro:");
                            nome[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine($"Digite o seu destino");
                            Destino[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine($"Digite seu local de origem");
                            Origem[counter] = Console.ReadLine();
                            Console.WriteLine();
                            
                            Console.WriteLine($"Digite a data que deseja viajar");
                            data[counter] = Console.ReadLine();
                            Console.WriteLine();

                            counter ++;

                            } else {
                            
                            Console.WriteLine("Limite excedido");
                            break;
                                   
                                   }
                            
                            Console.WriteLine();
                            Console.WriteLine("Gostaria de registrar outro passageiro sim(S) Não(N) ");
                            Console.WriteLine();
                            answer = Console.ReadLine().ToLower();

                            
                            } while (answer == "S");

                            Console.Clear();
                            break;
                           
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Mostrar passagens registradas");
                        Console.WriteLine();

                        for (int i = 0; i < counter; i++)
                        {
Console.WriteLine();
Console.WriteLine($"Passageiro: {nome[i]} | Origem: {Origem[i]} | Destino: {Destino[i]} | Data de viagem: {data[i]}");
                            
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Obrigado e Volte Sempre");
                        break;
                    
                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção escolhida não é valida");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            
            
            } while (escolha != 3);

            
            
            
        }
    }
}
