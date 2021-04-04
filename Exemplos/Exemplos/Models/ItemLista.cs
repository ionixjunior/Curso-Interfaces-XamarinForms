namespace Exemplos.Models
{
    public class ItemLista
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string Foto { get; set; }
        public string Passatempo { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
