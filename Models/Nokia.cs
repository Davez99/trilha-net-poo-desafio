namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia()
        {
            
        }
        public Nokia(string numero) : base(numero)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override int InstalarAplicativo(string nomeApp)
        {
            int valor = int.Parse(nomeApp);
            switch(valor){
                case 1:
                    Console.WriteLine("Removendo aplicações já instaladas");
                    Console.WriteLine("Instalando Nokia chamadas - Ligação");
                    Console.WriteLine("Instalação concluída");
                    break;
                case 2:
                    Console.WriteLine("Removendo aplicações já instaladas");
                    Console.WriteLine("Instalando Nokia receptivo - Receber Ligação");
                    Console.WriteLine("Instalação concluída");
                    break;
                case 3:
                    Console.WriteLine("Removendo aplicações já instaladas");
                    Console.WriteLine("Instalando Nokia Calendário - Datas e horas");
                    Console.WriteLine("Instalação concluída");
                    break;
            }
            return valor;
        }
    }
}