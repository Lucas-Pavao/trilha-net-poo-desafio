namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override string InstalarAplicativo()
        {
            return "Aplicativo Iphone instalado com sucesso!";
        }
    }
}