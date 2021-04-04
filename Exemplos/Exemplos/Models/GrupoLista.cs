using System.Collections.Generic;

namespace Exemplos.Models
{
    public class GrupoLista : List<ItemLista>
    {
        public string NomeDoGrupo { get; }

        public GrupoLista(string nomeDoGrupo, List<ItemLista> itens)
        {
            NomeDoGrupo = nomeDoGrupo;
            AddRange(itens);
        }
    }
}
