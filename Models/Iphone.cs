namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone()
        {
            
        }
        public Iphone(string numero) : base(numero)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override int InstalarAplicativo(string nomeApp)
        {
            int valor = int.Parse(nomeApp);
            

            switch(valor){
                case 1:
                    Console.WriteLine("Removendo aplicações já instaladas");
                    Console.WriteLine("Instalando Iphone call - Ligação");
                    Console.WriteLine("Instalação concluída");
                    break;
                case 2:
                    Console.WriteLine("Removendo aplicações já instaladas");
                    Console.WriteLine("Instalando Iphone Receive - Receber Ligação");
                    Console.WriteLine("Instalação concluída");
                    break;
                case 3:
                    Console.WriteLine("Removendo aplicações já instaladas");
                    Console.WriteLine("Instalando Iphone Calendar - Datas e horas");
                    Console.WriteLine("Instalação concluída");
                    break;
            }

            
            return valor;
        }
    }
}