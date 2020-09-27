## Capítulo 1: Controles primitivos
O objetivo é fazer um overview sobre todos os controles primitivos existentes (label, button...).

> #### Capítulo 1.1: Resumo do que será abordado

> #### Capítulo 1.2: Label
> - Introdução do Label
> - Customização de cores
> - Fonte
> - Tamanho
> - Truncamento
> - Limite de linhas.

> #### Capítulo 1.3: Image
> - Introdução do Image
> - Aspectos
> - Tamanho

> #### Capítulo 1.4: WebView
> - Introdução do WebView
> - Eventos

> #### Capítulo 1.5: Button
> - Introdução do Button
> - Customização de cores
> - Interações

> #### Capítulo 1.6: ImageButton
> - Complementa o contéudo do Button
> - Utilização de imagens

> #### Capítulo 1.7: Switch
> - Introdução do Switch
> - Customização de cores

> #### Capítulo 1.8: Picker
> - Introdução do Picker
> - Customização de cores
> - Fonte
> - Seleção de valor

> #### Capítulo 1.9: DatePicker
> - Introdução do DatePicker
> - Customização de cores
> - Fonte
> - Seleção de data

> #### Capítulo 1.10: TimePicker
> - Introdução do TimePicker
> - Customização de cores
> - Fonte
> - Seleção de hora

> #### Capítulo 1.11: Slider
> - Introdução do Slider
> - Customização de cores

> #### Capítulo 1.12: Stepper
> - Introdução do Stepper
> - Exemplos de aplicação

> #### Capítulo 1.13: RefreshView
> - Introdução do RefreshView
> - Exemplos de aplicação

> #### Capítulo 1.14: SearchBar
> - Introdução do SearchBar

> #### Capítulo 1.15: SwipeView
> - Introdução do SwipeView
> - Inserção de itens

> #### Capítulo 1.16: RadioButton
> - Introdução do RadioButton

> #### Capítulo 1.17: CheckBox
> - Introdução do CheckBox

> #### Capítulo 1.18: ActivityIndicator
> - Introdução do ActivityIndicator
> - Customizações de cores 

> #### Capítulo 1.19: ProgressBar
> - Introdução do ProgressBar
> - Customizações de cores

> #### Capítulo 1.20: Entry
> - Introdução do Entry
> - Digitando texto
> - Placeholder
> - Customização de cores
> - Fonte
> - Tipos de teclado
> - Transformação de texto
> - Limite de caracteres
> - Espaço entre caracteres
> - Senha
> - Tecla de retorno do teclado
> - Verificação ortográfica
> - Predição
> - Eventos

> #### Capítulo 1.21: Editor
> - Complementa o conteúdo do Entry abordando também o auto size

> #### Capítulo 1.22: ListView
> - Introdução do ListView
> - DataTemplate
> - Built-in cells
> - Custom cells
> - Tamanho das células
> - Agrupamento
> - Cabeçalho
> - Rodapé
> - Context Actions
> - Pull to refresh
> - Performance
> - Seleção

> #### Capítulo 1.23: CollectionView
> - Introdução do CollectionView
> - Layout
> - DataTemplate
> - Orientação
> - Agrupamento
> - Cabeçalho
> - Rodapé
> - Performance
> - Seleção

> #### Capítulo 1.24: TableView
> - Introdução do TableView
> - Tipos de apresentação
> - Customziações

> #### Capítulo 1.25: CarouselView
> - Conteúdo similar ao ListView e CollectionView, porém, mostrando as diferenças que o CarouselView tem

> #### Capítulo 1.26: IndicatorView
> - Utilização do IndicatorView com CarouselView

> #### Capítulo 1.27: BoxView
> - Introdução do BoxView
> - Customização de cor
> - Borda
> - Tamanho

> #### Capítulo 1.28: Shapes
> - Introdução do Shapes
> - Line
> - Rectangle
> - Ellipse
> - Path
> - Polygon
> - Polyline

> #### Capítulo 1.29: Propriedades em comum dos controles primitivos
> - Apresentar as propriedades em comum que muitos controles possuem - Translation, Scale, Rotate..

## Capítulo 2: Controles de layout
O objetivo é fazer um overview sobre todos os controles de layout existentes (stacklayout, flexlayout...)

## Capítulo 3: Controles de estrutura
O objetivo é fazer um overview sobre todos os controles de estrutura existentes (ContentPage, MasterDetailPage...)

## Capítulo 4: Compondo os controles
O objetivo é mostrar como podemos compor os elementos para criar layouts mais complexos. É possível que o HotReload / XAML Previewer seja apresentado aqui.

## Capítulo 5: Criando seus próprios controles
O objetivo é mostrar como criar controles customizados e reutilizáveis. Um bom capítulo para introduzir bindable properties e attached properties.

## Capítulo 6: Bindings
O objetivo é explicar sobre BindingContext, view-to-view bindings, binding mode e binding compilado.

> #### Capítulo 6.1: BindingContext
> - Explicar o conceito de `BindingContext` e para que ele serve nos controles;
> - Como funciona o `BindingContext` em camadas e em coleções;
> - Demonstrar Binding entre classes diferentes (ViewModels);
> #### Capítulo 6.2: View-to-View Bindings
> - Demonstrar Binding entre propriedades, controles, layouts, páginas, `parents` > (um _custom control_ pegar uma propriedade do elemento pai);
> #### Capítulo 6.3: BindingMode
> - Falar sobre os `BindingModes`, situações de uso, mostrar como podem afetar a performance
> #### Capítulo 6.3: Binding Compilado
> - Mostrar onde eles podem usados e suas limitações;
> - Mostrar as vantagens de utilizá-los (ganhos de performance e error em tempo de compilação)


## Capítulo 7: Styles
O objetivo é mostrar como criamos estilos no app de forma inline, com dicionários, explicar as diferenças entre StaticResources e DynamicResources e também como criar estilos com CSS. É um bom capítulo para abordar a criação de temas light / dark.

> #### Capítulo 7.1: Estilos no app
> - Explicar o conceito de `ResourceDictionary` e `MergedDictionary`;
> - Mostrar como podemos criar estilos diretamente na classe App.xaml;
> #### Capítulo 7.2: Criando estilos
> - Mostrar como podemos criar e consumir estilos em arquivos separados, apenas usando XAML(sem codebehind) e usando classe C#;
> - Falar sobre implicações de performance caso a se carregue muitos estilos no arquivo App.xaml.
> #### Capítulo 7.2: StaticResources
> - Falar sobre StaticResources, mostrando casos de uso e como consumí-los em XAML e em C#;
> #### Capítulo 7.3: DynamicResources
> - Falar sobre DynamicResources, mostrando casos de uso e como consumí-los em XAML e em C#;
> #### Capítulo 7.4: Estilos com CSS
> - Falar sobre Estilos com CSS, mostrando casos de uso e como consumí-los em XAML e em C#;



## Capítulo 8: Conversores
O objetivo é mostrar o uso de conversores nos bindings.

## Capítulo 9: Custom renderers
O objetivo é explicar o que são e para que servem os custom renderers fazendo exemplos práticos de implementações para o Android e iOS.

## Capítulo 10: Effects
O objetivo é mostrar o que são e para que servem os effects, além de mostrar as diferenças entre os custom renderers.

> #### Capítulo 10.1: Effects Simples
> - Criação de Effects simples;
> #### Capítulo 10.2: Effects Complexos
> - Criação de effects com Attached Properties;

## Capítulo 11: Triggers
O objetivo é mostrar o uso de triggers.

> #### Capítulo 11.1: DataTriggers
> #### Capítulo 11.2: EventTriggers
> #### Capítulo 11.3: MultiTriggers


## Capítulo 12: Visual State Manager
O objetivo é mostrar o uso de Visual State Manager para controlarmos estado de nossos controles.

## Capítulo 13: Imagens
O objetivo é mostrar como importar as imagens nos projetos e quais formatos usar (PNG, PDF, SVG, font icons), além de mostrar alguns exemplos de aplicação nas telas.

> #### Capítulo 13.1: Imagens
> - Mostrar os tipos de imagens e sua implicações;
> - Mostrar como reduzir tamanho de imagens;
> #### Capítulo 13.1: Renderizando Imagens
> - Falar sobre o controle de Imagem do XF;
> - Falar sobre como as plataformas lidam com a renderização de imagens;
> - Falar sobre GlideX e Nuke para reduzir o consumo de memória e processamento na hora de renderizar imagens

## Capítulo 14: Behaviors
O objetivo é mostrar como fazer uso dos behaviors.

## Capítulo 15: I18N
O objetivo é mostrar como fazer internacionalização no app usando os resources.

## Capítulo 16: L10N
O objetivo é mostrar como fazer localização no app.

## Capítulo 17: Data Templates
O objetivo é mostrar o uso e criação de data templates usando listas.

## Capítulo 18: Layout adaptativo
O objetivo é mostrar como podemos criar layouts adaptativos - algo parecido com o que foi feito na live do TNT.

## Capítulo 19: Acessibilidade
O objetivo é mostrar para que serve as propriedades de acessibilidade, para que são importantes e como utilizá-las. 

## Capítulo 20: Animações
O objetivo é apresentar a API de animações do Xamarin.Forms e mostrar com exemplos práticos como podemos utilizá-las - similar ao que estou fazendo com as animações do SoundCloud.

## Capítulo 21: Plugins
O objetivo é apresentar o Nuget e mostrar como podemos utilizar plugins nos apps fazendo exemplos mostrando o uso dos principais plugins que a comunidade mais usa.