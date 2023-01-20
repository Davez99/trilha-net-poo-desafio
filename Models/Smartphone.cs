namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone()
        {
            
        }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Relogio()
        {
            DateTime hora = DateTime.Now;
            Console.WriteLine($"{hora}");
        }

        public void MenuSmartphone(){
            bool exibirMenu = true;
            var retorno = 0;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha o aplicativo digitando a opção:");
                Console.WriteLine("1 - Instalar aplicativo");
                if(retorno == 1){Console.WriteLine("2 - Ligar");}
                if(retorno == 2){Console.WriteLine("3 - Receber ligação");}
                if(retorno == 3){Console.WriteLine("4 - Calendário");}                      
                Console.WriteLine("5 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Escolha o aplicativo para instalar:");                       
                        Console.WriteLine("1 - Ligar");
                        Console.WriteLine("2 - Receber ligação");
                        Console.WriteLine("3 - Calendário");
                        string escolha = Console.ReadLine();
                        retorno = InstalarAplicativo(escolha);
                        break;

                    case "2":
                        Ligar();
                        break;

                    case "3":
                        ReceberLigacao();
                        break;

                    case "4":
                        Relogio();
                        break;

                    case "5":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
        }

        public abstract int InstalarAplicativo(string nomeApp);
    }
}