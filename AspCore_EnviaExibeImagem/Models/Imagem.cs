namespace AspNetCore_EnviaExibeImagem.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Dados { get; set; }
        public string ContentType { get; set; }
    }
}
