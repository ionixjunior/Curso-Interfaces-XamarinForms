using System;
using System.Collections.Generic;
using Exemplos.Models;
using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploListView : ContentPage
    {
        public List<string> ListaSimples { get; } = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"
        };

        public List<ItemLista> ListaComplexa { get; } = new List<ItemLista>
        {
            new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
            new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
            new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Viajar" },
            new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Desenhar" },
            new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Programar algo que não sei" }
        };

        public List<GrupoLista> ListaAgrupada { get; } = new List<GrupoLista>
        {
            new GrupoLista("Grupo A", new List<ItemLista>
            {
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Viajar" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Desenhar" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Programar algo que não sei" }
            }),
            new GrupoLista("Grupo B", new List<ItemLista>
            {
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Viajar" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Desenhar" },
                new ItemLista { Nome = "Ione Souza Junior", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Programar algo que não sei" }
            })
        };

        public ExemploListView()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
