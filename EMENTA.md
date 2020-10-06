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

##### Roteiro da intro
Textos são utilizados em todos os aplicativos. Precisamos de textos para exibir nomes de menus, para mostrar uma mensagem que aparece na tela e também para mostrar o título de uma tela. E como a gente faz isso com Xamarin.Forms? A gente tem um controle chamado LABEL e é com ele que a gente pode representar textos no app. Nesse vídeo você vai ver como usar o Label, customizar cor da fonte, o alinhamento, enfim, o que é relacionado a esse controle. Blz? Bora lá então!

##### Roteiro da demo
Para representar um texto na tela, usamos o controle LABEL. E para inserir esse texto usamos a propriedade TEXT. Então, inserimos o texto desejado e fechamos a tag do controle. Ao salvar, o texto já aparecerá nos devices. 

Para alterar a cor do texto que inserimos, usamos a propriedade TEXT COLOR. Essa propriedade espera uma cor do framework, que pode ser informada usando as cores nomeadas.. ou então definida através de um valor hexadecimal.

Para alterar a cor de fundo do texto, usamos a propriedade BACKGROUND COLOR. Ela pode receber os mesmos tipos de valor que a propriedade TEXT COLOR. FALAR SOBRE O POSICIONAMENTO EM RELAÇÃO AO PAI; LAYOUT

Para alterar o tamanho do texto, usamos a propriedade FONT SIZE, onde podemos definir o tamanho usando um valor absoluto ou usando o tamanho das fontes nomeadas pelo sistema. Usar os valores de fontes nomeadas é importante para a acessibilidade, pois eles respeitam as configurações de acessibilidade realizadas no device.

Para alterar o tipo de fonte, usamos a propriedade FONT FAMILY, onde informamos as fontes que estão instaladas no SO. Podemos utilizar fontes customizadas, mas não vamos abordar isso agora.

Existem alguns atributos que podemos customizar nas fontes, para isso, usamos a propriedade FONT ATTRIBUTES, onde podemos ajustá-la como BOLD ou ITALIC.

Podemos também decorar um texto usando a propriedade TEXT DECORATION, onde podemos inserir um efeito de texto riscado.. ou sublinhado.

Existe também algumas transformações que podemos fazer no texto, e fazemos isso através da propriedade TEXT TRANSFORM. Com ela, podemos alterar o texto para deixar todas as letras minúsculas… ou maiúsculas.

Para ajustar o espaçamento entre caracteres, usamos a propriedade CHARACTER SPACING, onde informamos um valor absoluto.

Em textos grandes, talvez seja necessário limitar a exibição dos caracteres. Para isso, usamos a propriedade LINE BREAK MODE. A configuração mais comum é TAIL TRUNCATION, onde o texto é truncado no final e é inserido 3 pontos no final do texto indicando que o mesmo não acabou. Mas o texto também pode ser truncado no começo com HEAD TRUNCATION, no centro com MIDDLE TRUNCATION, o truncamento pode ser ignorado com a propriedade NO WRAP.. ou o truncamento pode ser feito através de palavras com WORDWRAP. AQUI É IMPORTANTE REVISAR POIS WORDWRAP NÃO É TRUNCADO

Podemos também configurar a quantidade de linhas que queremos exibir usando a propriedade MAX LINES. 

O texto pode ser alinhado horizontalmente com a propriedade HORIZONTAL TEXT ALIGHMENT. Por padrão, ele é alinhado com o valor START, mas podemos configurar como END ou CENTER.

Também podemos alinhar o texto verticalmente com a propriedade VERTICAL TEXT ALIGHMENT, que funciona da mesma forma que o alinhamento horizontal.

> #### Capítulo 1.3: Image
> - Introdução do Image
> - Aspectos
> - Tamanho

##### Roteiro da intro
Imagens também estão presentes na maioria dos aplicativos. Usamos elas para visualizar a foto de um post de uma rede social, a foto de um avatar ou até mesmo para mostrar um ícone na tela. Para usarmos imagens temos um controle chamado Image, e é sobre ele que vamos falar agora. Bora lá!

> #### Capítulo 1.4: WebView
> - Introdução do WebView
> - Eventos

##### Roteiro da intro
As vezes é necessário carregar uma página da internet dentro do aplicativo, e pra isso a gente pode usar um controle chamado WebView. Com o WebView a gente consegue navegar para uma página e também avançar ou retroceder na navegação. Vamos conferir como usar o WebView. Bora lá!

> #### Capítulo 1.5: Button
> - Introdução do Button
> - Customização de cores
> - Interações

##### Roteiro da intro
A todo instante fazemos interações nas telas dos devices e geralmente é pra executar uma ação - baixar uma imagem ou salvar as informações de uma tela. Na maioria das vezes isso é feito através de um botão, e é sobre isso que vamos falar agora, um controle chamado Button. Bora lá!

> #### Capítulo 1.6: ImageButton
> - Complementa o contéudo do Button
> - Utilização de imagens

##### Roteiro da intro
Botões também podem ter imagens e nesse vídeo veremos como funciona o controle ImageButton; uma derivação do controle Button. Bora lá!

> #### Capítulo 1.7: Switch
> - Introdução do Switch
> - Customização de cores

##### Roteiro da intro
É comum existir nos apps telas para ativamos ou desativarmos alguma configuração, por exemplo: para fazer o uso de notificações push ou então habilitar a biometria para poder validar alguma ação no app. Para isso existe um controle chamado Switch e nós vamos descobrir como usar e customizar ele agora. Bora lá!

> #### Capítulo 1.8: Picker
> - Introdução do Picker
> - Customização de cores
> - Fonte
> - Seleção de valor

##### Roteiro da intro
É provável que você já preencheu uma tela de cadastro onde precisou informar o Estado onde você mora. Como os Estados são opções pré-definidos, você não digita eles, você, geralmente, os seleciona. A gente consegue fazer isso também em uma aplicação mobile e, no Xamarin.Forms, a utilizamos o controle Picker. Então, vamos ver como funciona o Picker, customização de cores, fonte, seleção de valor. Blz? Bora lá!

> #### Capítulo 1.9: DatePicker
> - Introdução do DatePicker
> - Customização de cores
> - Fonte
> - Seleção de data

##### Roteiro da intro
As vezes precisamos informar uma data no aplicativo, seja para preencher um cadastro ou para fazer um filtro em uma tela. Para isso usamos o DatePicker, um controle com a mesma ideia do Picker mas para fazer seleção de uma data do calendário. Então, vamos ver como usar e customizar esse controle. Bora lá!

> #### Capítulo 1.10: TimePicker
> - Introdução do TimePicker
> - Customização de cores
> - Fonte
> - Seleção de hora

##### Roteiro da intro
Além de data, também podemos informar no aplicativo o valor de um horário, e a gente tem um controle específico para isso: o TimePicker, que é um controle bem parecido com o DatePicker. Vamos ver como funciona? Bora lá!

> #### Capítulo 1.11: Slider
> - Introdução do Slider
> - Customização de cores

##### Roteiro da intro
Em determinados aplicativos precisamos realizar ajustes finos em algumas configurações, por exemplo: controlar o volume do áudio ou ajustar o brilho da tela. Pra isso existe o controle Slider, que como o próprio nome já diz, serve pra gente interagir com o controle deslizando o dedo na tela. Vamos conferir como fazer o uso desse controle. Bora lá!

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