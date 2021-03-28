using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Exemplos.Models;
using Xamarin.Forms;

namespace Exemplos.ViewModels
{
    public class ExemploListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
            new ItemLista { Nome = "João da Silva", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
            new ItemLista { Nome = "Ana Pereira", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
            new ItemLista { Nome = "Augusto Souza", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Viajar" },
            new ItemLista { Nome = "Marina Gonçalves", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Desenhar" },
            new ItemLista { Nome = "Mateus Vilela", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Programar algo que não sei" },
            new ItemLista { Nome = "Júlia Lima", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Estudar" }
        };

        public ObservableCollection<GrupoLista> ListaAgrupada { get; } = new ObservableCollection<GrupoLista>
        {
            new GrupoLista("Grupo A", new List<ItemLista>
            {
                new ItemLista { Nome = "João da Silva", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
                new ItemLista { Nome = "Ana Pereira", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
                new ItemLista { Nome = "Augusto Souza", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Viajar" },
                new ItemLista { Nome = "Marina Gonçalves", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Desenhar" },
                new ItemLista { Nome = "Mateus Vilela", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Programar algo que não sei" },
                new ItemLista { Nome = "Júlia Lima", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Estudar" }
            }),
            new GrupoLista("Grupo B", new List<ItemLista>
            {
                new ItemLista { Nome = "João da Silva", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
                new ItemLista { Nome = "Ana Pereira", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
                new ItemLista { Nome = "Augusto Souza", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Viajar" },
                new ItemLista { Nome = "Marina Gonçalves", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Desenhar" },
                new ItemLista { Nome = "Mateus Vilela", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Programar algo que não sei" },
                new ItemLista { Nome = "Júlia Lima", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Estudar" }
            })
        };

        public Command AtualizarListaAgrupadaCommand { get; private set; }

        private bool _estaAtualizandoALista;
        public bool EstaAtualizandoALista
        {
            get => _estaAtualizandoALista;
            set
            {
                _estaAtualizandoALista = value;
                OnPropertyChanged();
            }
        }

        public ExemploListViewModel()
        {
            AtualizarListaAgrupadaCommand = new Command(() => AtualizarListaAgrupada());
        }

        private void AtualizarListaAgrupada()
        {
            EstaAtualizandoALista = true;
            ListaAgrupada.Clear();
            ListaAgrupada.Add(new GrupoLista("Grupo A", new List<ItemLista>
            {
                new ItemLista { Nome = "Camila Soares", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Jogar cartas" },
                new ItemLista { Nome = "Julio Cardoso", Profissao = "Desenvolvedor Mobile", Foto = "banana.png", Passatempo = "Jogar Tony Hawk" },
                new ItemLista { Nome = "Cibele Martins", Profissao = "Desenvolvedora Mobile", Foto = "banana.png", Passatempo = "Viajar" }
            }));
            EstaAtualizandoALista = false;
        }
    }
}
