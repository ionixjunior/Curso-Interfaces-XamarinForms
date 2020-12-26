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

Para alterar a cor de fundo do texto, usamos a propriedade BACKGROUND COLOR. Ela pode receber os mesmos tipos de valor que a propriedade TEXT COLOR.

Para alterar o tamanho do texto, usamos a propriedade FONT SIZE, onde podemos definir o tamanho usando um valor absoluto ou usando o tamanho das fontes nomeadas pelo sistema. Usar os valores de fontes nomeadas é importante para a acessibilidade, pois eles respeitam as configurações de acessibilidade realizadas no device. Para este exemplo, vou usar um tamanho de fonte absoluto para facilitar a explicação.

Para alterar o tipo de fonte, usamos a propriedade FONT FAMILY, onde informamos as fontes que estão instaladas no SO. Podemos utilizar fontes customizadas, mas não vamos abordar isso agora. É importante lembrar que as fontes disponíveis em cada sistema operacional são diferentes, então, vou descartar essa propriedade agora e deixar isso para um capítulo avançado.

Existem alguns atributos que podemos customizar nas fontes, para isso, usamos a propriedade FONT ATTRIBUTES, onde podemos ajustá-la como BOLD, ITALIC ou combiná-las, separando os valores por vírgula.

Podemos também decorar um texto usando a propriedade TEXT DECORATION, onde podemos inserir um efeito de texto riscado, sublinhado, ou combiná-los, igual fizemos na propriedade anterior.

Existe também algumas transformações que podemos fazer no texto, e fazemos isso através da propriedade TEXT TRANSFORM. Com ela, podemos alterar o texto para deixar todas as letras minúsculas… ou maiúsculas.

Para ajustar o espaçamento entre caracteres, usamos a propriedade CHARACTER SPACING, onde informamos um valor absoluto.

Em textos grandes, talvez seja necessário limitar a exibição dos caracteres. Para isso, usamos a propriedade LINE BREAK MODE. A configuração mais comum é TAIL TRUNCATION, onde o texto é truncado no final e é inserido 3 pontos no final do texto indicando que o mesmo não acabou. Mas o texto também pode ser truncado no começo com HEAD TRUNCATION, no centro com MIDDLE TRUNCATION, o truncamento pode ser ignorado com a propriedade NO WRAP, ou ao invés do truncamento, pode ser feita a quebra de linha entre caracteres usando CHARACTER WRAP. A opção padrão é a WORD WRAP, que faz a quebra de linha por palavras.

Podemos também configurar a quantidade de linhas que queremos exibir usando a propriedade MAX LINES. 

O texto pode ser alinhado horizontalmente com a propriedade HORIZONTAL TEXT ALIGNMENT. Por padrão, ele é alinhado com o valor START, mas podemos configurar como END ou CENTER.

Também podemos alinhar o texto verticalmente com a propriedade VERTICAL TEXT ALIGNMENT, que funciona com os mesmos valores da propriedade de alinhamento horizontal.

##### Roteiro da finalização
Agora que você já sabe trabalhar com o LABEL, vamos ver como é trabalhar com os demais controles. Te vejo no próximo vídeo!

> #### Capítulo 1.3: Image
> - Introdução do Image
> - Aspectos
> - Tamanho

##### Roteiro da intro
Imagens também estão presentes na maioria dos aplicativos. Usamos elas para visualizar a foto de um post de uma rede social, a foto de um avatar ou até mesmo para mostrar um ícone na tela. Para usarmos imagens temos um controle chamado Image, e é sobre ele que vamos falar agora. Bora lá!

##### Roteiro da demo
Para mostrar uma imagem na tela, usamos o controle IMAGE seguido do atributo SOURCE, onde especificamos a imagem que queremos utilizar. Essa imagem pode ser representada através de um link ou a partir do nome de uma imagem que estão nos projetos das plataformas, que no nosso caso, são Android e iOS.

A imagem também possui uma propriedade de cor de fundo, e podemos customizá-la alterando o BACKGROUND COLOR, onde informamos a cor desejada. 

Para alterar o aspecto da imagem usamos a propriedade ASPECT, e podemos fazer a imagem preencher todo o espaço que o controle ocupa usando o valor FILL, mas a imagem ficará distorcida por conta do tamanho da tela do device ser diferente do tamanho da imagem. Para essa distorção não acontecer, usamos o valor ASPECT FILL, que faz preencher a imagem em todo o espaço disponível e corta os cantos que excedem as extremidades da tela. A configuração padrão é ASPECT FIT, que faz exibir a imagem inteira na tela e sem distorções. 

A imagem pode ter seu layout ajustado na horizontal com a propriedade HORIZONTAL OPTIONS. Existem diversas opções de alinhamento, como START, CENTER, END e FILL. Talvez você não veja a diferença entre elas pois a largura dessa imagem é maior do que o tamanho da tela. Eu vou colocar o dispositivo em modo paisagem para visualizarmos essas diferenças. START, CENTER, END e FILL, que é a opção padrão. Para todas essas opções, também existe a possibilidade de expansão, mas abordaremos elas somente quando falarmos sobre layout.

Agora vamos voltar o dispositivo para a orientação em modo retrato para falar sobre a propriedade VERTICAL OPTIONS, que possui as mesmas características da propriedade abordada anteriormente, só que para alinhamento vertical. START, CENTER, END e FILL.

Podemos especificar um tamanho para a imagem, basta declarar os atributos WIDTH REQUEST e HEIGHT REQUEST para atribuir os valores de largura e altura, respectivamente. Esses valores parecem que não fizeram efeito. Na verdade, eles trabalham em conjunto com as opções de layout definidas acima. Como configuramos o layout para preencher a tela, que é a opção FILL, a largura e altura definidas aqui são descartadas. Então, vou definir o valor CENTER nos layouts para que a imagem não seja renderizada seguindo todo o tamanho do controle e sim dos valores que definimos. Após essa mudança, podemos realizar as alterações de largura e altura. 

O controle também é capaz de carregar gifs, basta referenciarmos o arquivo na propriedade SOURCE, seja por uma URL ou local. Por padrão, o gif não será executado, então, utilizamos a propriedade IS ANIMATION PLAYING para ativar esse recurso.

##### Roteiro da finalização
E aí, o que você achou do vídeo? Conta aí pra gente! Deixa o seu comentário e não esquece de dar o like. Valeu, até o próximo vídeo!

> #### Capítulo 1.4: WebView
> - Introdução do WebView
> - Eventos

##### Roteiro da intro
As vezes é necessário carregar uma página da internet dentro do aplicativo, e pra isso a gente pode usar um controle chamado WebView. Com o WebView a gente consegue navegar para uma página e também avançar ou retroceder na navegação. Vamos conferir como usar o WebView. Bora lá!

##### Roteiro da demo
Para exibirmos uma página HTML dentro do aplicativo, basta usar o controle WEBVIEW e adicionar um link no atributo SOURCE. Neste exemplo estou usando um link da internet, mas também podemos utilizar uma página HTML que esteja dentro do aplicativo nas pastas dos resources.

O WebView possui alguns eventos para capturarmos quais são as páginas que foram navegadas ou que desejamos navegar. Estes eventos são chamados de NAVIGATED E NAVIGATING, respectivamente. Para utilizá-los, basta assinar no controle o evento NAVIGATED. O autocomplete irá sugerir a criação de um método no code behind da tela que será invocado pelo evento do WebView. Ao criarmos, podemos verificar através do argumento qual é o link que foi navegado. Para visualizarmos as alterações temos que fazer um novo deploy no dispositivo, pois o hot reload não funciona no code behind. Após o deploy, podemos verificar o evento ser invocado logo quando a tela inicial é carregada e em todas as demais navegações que fizermos. Este evento acontece sempre que uma navegação termina.

O evento NAVIGATING funciona da mesma forma, só que ele é acionado antes da navegação ser realizada. Repare que ele é invocado diversas vezes e isso é normal, pois ao navegarmos em um site, é comum existirem redirecionamentos até chegarmos ao destino final de nossa requisição.

Agora você deve estar se perguntando: Mas para que eu preciso monitorar quais os links que estou navegando ou que eu vou navegar? A resposta é simples: Você pode precisar monitorar um determinado link que você está navegando para fazer uma ação dentro do aplicativo, como uma reautenticação de usuário, por exemplo, ou até para interromper o acesso a determinado tipo de página.

##### Roteiro da finalização
O que você achou deste vídeo? Deixe o seu comentário falando para a gente e não esquece de dar o like para ajudar com que este conteúdo chegue a mais pessoas. Obrigado e até o próximo vídeo!

> #### Capítulo 1.5: Button
> - Introdução do Button
> - Customização de cores
> - Interações

##### Roteiro da intro
A todo instante fazemos interações nas telas dos devices e geralmente é pra executar uma ação - baixar uma imagem ou salvar as informações de uma tela. Na maioria das vezes isso é feito através de um botão, e é sobre isso que vamos falar agora, um controle chamado Button. Bora lá!

##### Roteiro da demo
Para exibirmos um botão no aplicativo, utilizamos o controle BUTTON seguido da propriedade TEXT onde definimos o texto do botão. 

Assim como no LABEL, o texto do botão também tem configurações semelhantes, como: alteração da cor do texto, tamanho da fonte, atributos e transformações. Para maiores detalhes, veja o vídeo que fala em detalhes sobre o controle LABEL.

Podemos também definir um cor de fundo através da propriedade BACKGROUND COLOR. O controle está preenchido na tela inteira, então, vou configurar seu layout para centralizar na pagina através das propriedades HORIZONTAL OPTIONS e VERTICAL OPTIONS.

Para definir uma largura e altura fixa para o botão, usamos as propriedades WIDTH REQUEST e HEIGHT REQUEST, respectivamente.

O botão pode ter bordas arredondadas, e para isso, utilizamos a propriedade CORNER RADIUS, onde especificamos um valor absoluto.

O botão possui bordas, e para que elas aparecem, basta especificarmos a propriedade BORDER WIDTH e inserir o tamanho da borda que desejamos. Ainda sobre a borda, podemos escolher a cor dela usando a propridade BORDER COLOR. 

Podemos inserir uma imagem neste botão através da propriedade IMAGE SOURCE, que pode ser um link da internet ou o nome da imagem presentes nos resources da aplicação. Não temos muito controle sobre a imagem aqui, então, esteja ciente de que a imagem deve ser pequena e adequada para ser exibida no botão. É importante lembrar que gifs animados não funcionam neste controle. Será exibido apenas o primeiro quadro do gif.

Mas conseguimos alterar o posicionamento da imagem usando a propriedade CONTENT LAYOUT, onde especificamos onde desejamos visualizá-la com as opções LEFT, RIGHT, BOTTOM e TOP. Também podemos especificar uma distância entre a imagem e o texto do botão. Para isso, basta adicionarmos um valor absoluto juntamente da opção de layout desejada.

Este botão é clicável e podemos vê-lo esmaecido quando clicamos e seguramos. Podemos também capturar esse clique para realizarmos alguma operação no app, e isso pode ser feito através de comandos ou eventos. Agora, apenas vamos ver como isso se dá através de eventos. Basta assinarmos o evento CLICKED. O Visual Studio vai criar um novo método no code behind da tela. Agora, este método está sendo executado toda vez que o botão é clicado e você pode realizar alguma ação a partir daqui.

Além do evento CLICKED, também temos os eventos PRESSED e RELEASED, que são invocados quando o botão é pressionado e solto. A forma que usamos eles é da mesma maneira do evento CLICKED. Cada um destes eventos representa um estado: botão pressionado - que é o evento PRESSED; botão solto - que é o evento RELEASED; e botão clicado - que é o evento CLICKED, que acontece após o botão ter sido solto.

##### Roteiro da finalização
Com certeza você vai usar muito esse controle. Gostou do vídeo? Conta para a gente, escreve aí o seu comentário dizendo o que você achou. E não esquece de dar o like no vídeo e se inscrever no canal, blz? Um abraço e até o próximo vídeo!

##### Bugs relacionados
- https://github.com/xamarin/Xamarin.Forms/issues/9227

> #### Capítulo 1.6: ImageButton
> - Complementa o contéudo do Button
> - Utilização de imagens

##### Roteiro da intro
As vezes queremos que imagens tenham a mesma ação de um botão e nesse vídeo veremos como funciona o controle ImageButton; uma derivação do controle Button. Bora lá!

##### Roteiro da demo
O IMAGE BUTTON reúne as funcionalidades de um controle de imagem e de um controle de botão em um só. Se você já viu os vídeos anteriores sobre IMAGE e BUTTON, verá que poderá mesclar este conhecimento usando apenas um único controle. Mas existem algumas exceções, por exemplo: a imagem não possui texto, então, não é possível você adicionar um texto neste botão, somente imagem. Outra limitação é que, assim como no BUTTON, não conseguimos usar gifs animados. Eles aparecerão, mas apenas o primeiro frame.

Um ponto importante a destacar no IMAGE BUTTON é a possibilidade de utilizarmos um espaçamento interno para a renderização do botão. Vamos supor que estamos usando um ícone pequeno para o botão, então, a área clicável dele será menor do que a de um botão convencional e talvez prejudique a usabilidade de quem usar o aplicativo. Como fazemos para aumentar a área clicável deste botão e melhorar a experiência do usuário? Podemos fazer isso através da propriedade PADDING. Com ela, definimos um valor do espaçamento interno do botão. O valor deve ser inserido de forma absoluta e, quando especificado apenas 1 valor, vale para todas as extremidadas da imagem do botão. 

Mas podemos definir valores diferentes para cada extremidade, basta inserirmos os 4 valores separados por vírgula, começando pelo valor da esquerda, topo, direita e rodapé. Podemos também simplificar essa declaração inserindo 2 valores separados por vírgula, onde o primeiro valor corresponde a esquerda e direita e o segundo valor corresponde ao topo e rodapé. 

Muitos controles possuem a propriedade PADDING, e nós vamos abordar isso com detalhes mais para frente.

##### Roteiro da finalização
E aí! O que você está achando do curso? Comenta aí para a gente saber. Um abraço e até o próximo vídeo!

> #### Capítulo 1.7: Switch
> - Introdução do Switch
> - Customização de cores

##### Roteiro da intro
É comum existir nos apps telas para ativamos ou desativarmos alguma configuração, por exemplo: para fazer o uso de notificações push ou então habilitar a biometria para poder validar alguma ação no app. Para isso existe um controle chamado Switch e nós vamos descobrir como usar e customizar ele agora. Bora lá!

##### Roteido da demo
Para visualizá-lo na tela, utilizamos o controle SWITCH. Ele armazena um valor booleano, que é verdadeiro ou falso, e para customizar esse valor, utilizamos a propriedade IS TOGGLED com o valor que desejarmos.

As cores que aparecem são as padrões de cada um dos sistemas operacionais que estivermos utilizando, mas podemos alterar. Com a propriedade ON COLOR, alteramos a cor do controle que é exibido quando ele estiver ativado. Já a propriedade THUMB COLOR altera apenas a cor do item do controle que fica sempre visível.

Quando realizamos a alteração de valor do controle, um evento é invocado. Podemos assinar este evento para realizarmos alguma operação na aplicação. Para isso, assinamos o evento TOGGLED, e aí podemos definir nossa rotina no code behind. No evento que é disparado, conseguimos descobrir se o controle está ativo ou não através do valor no argumento.

##### Roteiro da finalização
Esse foi mais um vídeo deste curso. O que você está achando? Conta pra gente, deixa o seu comentário aí no vídeo e também dá aquele like, caso tenha gostado. Um abraço e até próxima!

> #### Capítulo 1.8: Picker
> - Introdução do Picker
> - Customização de cores
> - Fonte
> - Seleção de valor

##### Roteiro da intro
É provável que você já preencheu uma tela de cadastro onde precisou informar o Estado onde você mora. Como os Estados são opções pré-definidos, você não digita eles, você, geralmente, os seleciona. A gente consegue fazer isso também em uma aplicação mobile e, no Xamarin.Forms, a utilizamos o controle Picker. Então, vamos ver como funciona o Picker, customização de cores, fonte, seleção de valor. Blz? Bora lá!

##### Roteiro da demo
Para vermos o elemento em tela, usamos o controle PICKER e definimos o atributo TITLE. Este texto indica onde está o controle, mas para ficar mais fácil o entendimento, vamos colorí-lo usando a propriedade BACKGROUND COLOR. Também vou configurar o layout horizontal e vertical no centro. 

O título configurado possui alguns atributos em comum ao LABEL, tais como FONT ATTRIBUTES e HORIZONTAL TEXT ALIGNMENT. Ele também possui a propriedade para colorir seu texto, que é TITLE COLOR.

Ao clicar neste controle, as opções para selecionar aparecem na tela, mas ainda não configuramos nenhuma. Então, vamos atribuir na propriedade ITEMS SOURCE uma lista de strings. Para facilitar a explicação, faremos isso no code behind, para isso, nomeamos o controle no XAML para utilizarmos ele na classe da tela, onde vamos definir uma lista com valores string e a atribuímos na propriedade ITEMS SOURCE do PICKER. 

Podemos popular o PICKER e já selecionar um valor por padrão. Para isso, usamos a propriedade SELECTED INDEX para indicar qual índice da lista deve ser selecionado. Vou selecionar o índice 2 da lista, que é o último item. Também podemos fazer isso através da propriedade SELECTED ITEM, onde informamos qual o item da lista que deve ser selecionado. Vou selecionar o último item também, mas usando o LINQ do C#.

Ao invés de trabalharmos com tipos string, podemos trabalhar com tipos complexos. No entanto, o PICKER não saberá qual propriedade do objeto complexo deve exibir na tela. Uma maneira fácil de resolver isso é fazendo a sobrecarga do método TO STRING do objeto complexo. É possível realizar isso através de bindings, mas não abordaremos isso neste capítulo.

O valor selecionado possui cor independente, que pode ser customizada através do atributo TEXT COLOR.

Podemos monitorar quando um valor é selecionado, e então, realizar alguma ação no aplicativo. Para isso, assinamos o evento SELECTED INDEX CHANGED. Desta forma, podemos verificar qual é o SELECTED INDEX ou SELECTED ITEM que está selecionado no controle.

##### Roteiro da finalização
E aí, gostou? Conta pra gente o que você está achando do curso, e não esquece de dar o like aí no vídeo. Até o próximo vídeo!

> #### Capítulo 1.9: DatePicker
> - Introdução do DatePicker
> - Customização de cores
> - Fonte
> - Seleção de data

##### Links úteis
- https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-date-and-time-format-strings

##### Roteiro da intro
As vezes precisamos informar uma data no aplicativo, seja para preencher um cadastro ou para fazer um filtro em uma tela. Para isso usamos o DatePicker, um controle com a mesma ideia do Picker mas para fazer seleção de uma data do calendário. Então, vamos ver como usar e customizar esse controle. Bora lá!

##### Roteiro da demo
Para informarmos um valor de data no aplicativo, usamos o controle DATE PICKER. Por padrão, ele já irá exibir a data atual no controle. A formatação desta data depende das configurações de idioma e região do seu dispositivo, pois o controle já traduz e localiza automaticamente. 

Para facilitar o entendimento dos exemplos, vou centralizar o controle na horizontal e vertical, e inserir uma cor de fundo.

Algumas propriedades utilizadas no LABEL também estão presentes aqui, como FONT ATTRIBUTES e TEXT COLOR.

Para alterar o formato da data exibida, usamos o atributo FORMAT, onde configuramos o formato baseado na cadeia de caracteres do DateTime do C#. Uma data por extenso, por exemplo, é expressa pela letra D, mas existem diversos tipos de formatações.

Para selecionar uma data, basta clicarmos no controle e fazer a seleção da data desejada. Veja que cada plataforma possui suas particularidades, pois o controle usa os mecanismos nativos de cada plataforma. 

Podemos definir uma data específica utilizando a propriedade DATE. É possível fazer isso diretamente no XAML, mas não é algo comum, pois a data precisa estar em formato específico, que é mês, dia e ano. Então, faremos isso no code behind. Para isso, vou definir um nome para o controle para podermos utilizá-lo lá na classe da tela. Desta forma, conseguimos especificar um objeto do tipo DATE TIME e evitamos erros de formatação.

É possível também definir um range com data mínima e máxima para seleção, basta definirmos valores para as propriedades MINIMUM DATE e MAXIMUM DATE.

Assim como em outros controles, no DATE PICKER também é possível descobrir quando um valor foi alterado, para isso, assinamos o evento DATE SELECTED, que é invocado quando uma data no calendário é selecionada. Neste evento, conseguimos descobrir no argumento o novo valor selecionado e também o valor selecionado anteriormente.

##### Roteiro da finalização
O que você está achando do curso? Escreve o seu comentário dando uma dica ou fazendo uma sugestão. Um abraço e até o próximo vídeo!

> #### Capítulo 1.10: TimePicker
> - Introdução do TimePicker
> - Customização de cores
> - Fonte
> - Seleção de hora

##### Roteiro da intro
Além de data, também podemos informar no aplicativo o valor de um horário, e a gente tem um controle específico para isso: o TimePicker, que é um controle bem parecido com o DatePicker. Vamos ver como funciona? Bora lá!

##### Roteiro da demo
Para informar um valor de hora no aplicativo, usamos o controle TIME PICKER. Este é um controle que possui um funcionamento muito parecido com o DATE PICKER, mas serve apenas para fazer a seleção de horário. 

Sua formatação também segue a cadeia de caracteres para exibir hora no C#, e este formato pode ser customizado também através da propriedade FORMAT.

Para definir um horário específico, usamos a propriedade TIME. E, assim como o DATE PICKER, podemos fazer isso tanto no XAML quanto no code behind. 

O TIME PICKER não possui um evento que é disparado quando uma hora é selecionada, mas é possível descobrirmos quando isso acontece. Para isso, assinamos o evento PROPERTY CHANGED e verificamos se a propriedade alterada é a "TIME". Desta forma, descobrimos o valor da hora selecionada no controle.

É importante lembrar que este controle segue os padrões de localização, então, dependendo da região, a data poderá ser visualizada de forma diferente, de 0 à 23 horas ou 0 à 12 horas AM ou PM.

##### Roteiro da finalização
E aí, gostou? Conta pra gente o que você está achando do curso, e não esquece de dar o like aí no vídeo. Valeu!

> #### Capítulo 1.11: Slider
> - Introdução do Slider
> - Customização de cores

##### Roteiro da intro
Em determinados aplicativos precisamos realizar ajustes finos em algumas configurações, por exemplo: controlar o volume do áudio ou ajustar o brilho da tela. Pra isso existe o controle Slider, que como o próprio nome já diz, serve pra gente interagir com o controle deslizando o dedo na tela. Vamos conferir como fazer o uso desse controle. Bora lá!

##### Roteiro da demo
Para utilizar o controle, usamos o SLIDER no XAML ou code behind. Ao inserir o controle, é bom definirmos seu range, então, utilizamos as propriedades MINIMUM e MAXIMUM para delimitar seus valores. Caso não definirmos, o range padrão é de 0 até 1. 

Podemos mover o SLIDER para a posição que desejarmos movendo o botão do controle, ou então, definindo seu valor usando a propriedade VALUE, onde essa propriedade deve obedecer o range definido.

As cores do controle também são customizáveis. Podemos colorir a barra da esquerda do botão do controle com a propriedade MINIMUM TRACK COLOR, e a barra da direita com a propriedade MAXIMUM TRACK COLOR. 

O botão nós podemos colorir com a propriedade THUMB COLOR, ou então, utilizar uma imagem para exibí-lo com a propriedade THUMB IMAGE SOURCE.

Ao utilizarmos o SLIDER, podemos descobrir seu valor assinando o evento VALUE CHANGED, onde temos disponível no argumento o novo e o antigo valor do controle.

##### Roteiro da finalização
E aí, o que você está achando do curso? Conta para a gente aí nos comentários e não esquece de dar aquele like no vídeo, caso tenha gostado do conteúdo. Um abraço e até o próximo vídeo!

> #### Capítulo 1.12: Stepper
> - Introdução do Stepper
> - Exemplos de aplicação

##### Roteiro da intro
É muito comum em aplicativos de e-commerce ou delivery termos a opção de acrescentar ou remover um item em uma unidade, comumente representado por dois botões alinhados lado a lado, a grande maioria com o símbolo de + e -. O XF possui esse controle pronto para uso, vamos ver como ele funciona na prática?

> #### Capítulo 1.13: RefreshView
> - Introdução do RefreshView
> - Exemplos de aplicação

##### Roteiro da intro
Você já ouviu falar no termo _Pull to Refresh_? Se você utiliza aplicativos de rede social, com certeza já fez uso dessa funcionalidade. No Xamarin.Forms era oferecido suporte para este controle apenas no ListView, porém na versão 4.3 ele foi convertido em uma ContentView que pode ser usada em qualquer layout ou conjunto de views. Vamos ver como ele funciona?

> #### Capítulo 1.14: SearchBar
> - Introdução do SearchBar

##### Roteiro da intro
As plataformas nativas nos fornecem um controle de busca, muito utilizado quando você quer pesquisar ou filtrar por um item ou termos em específico. O XF possui uma abstração desse controle o que nos facilita muito na hora de implementar um controle desse tipo. Vamos ver como ele funciona?

> #### Capítulo 1.15: SwipeView
> - Introdução do SwipeView
> - Inserção de itens

##### Roteiro da intro
Muito comumente, em aplicativos de e-mail, você possui ações quando vc desliza o dedo sob uma célula da esquerda pra direita e ou da direita para esquerda, normalmente aparece uma outra view, como se estivesse escondida atrás da célula. A partir da versão 4.4 do XF podemos fazer isso facilmente com o uso do SwipeView, ele ainda é um controle experimental, mas ficará estável na versão 5.0 do XF. Chega de conversa e vamos ver como utilizá-lo na prática.

> #### Capítulo 1.16: RadioButton
> - Introdução do RadioButton

##### Roteiro da intro
Em certos formulários com opções de múltipla escolha, você quer o que o usuário selecione apenas uma das opções disponíveis. Isso pode ser feito facilmente com o controle RadioButton. Neste vídeo você verá como usá-lo e também vamos dar uma nas novidas que virão na versão 5.0 do XF o _Templated RadioButtons_ e _RadioButtonGroups_. Vamos lá?

> #### Capítulo 1.17: CheckBox
> - Introdução do CheckBox

##### Roteiro da intro
O controle CheckBox é semelhante ao controle _RadioButton_, a diferença é que ele permite que vc selecione mais de uma opção, das opções disponíveis. Vamos ver como podemos usar esse controle?

> #### Capítulo 1.18: ActivityIndicator
> - Introdução do ActivityIndicator
> - Customizações de cores 

##### Roteiro da intro
Sempre que precisamos fazer um longo processo, como uma chamada de API ou um longo processamento, é bom mostrar ao usuário alguma indicação visual de que o app não está "travado" e sim "pensando". Para isso usamos o ActivityIndicator. Vamos ver como ele funciona na prática?

> #### Capítulo 1.19: ProgressBar
> - Introdução do ProgressBar
> - Customizações de cores

##### Roteiro da intro
O ProgressBar é um controle, que assim como o ActivityIndicator, serve para mostrar que o app está fazendo um trabalho de longa duração. A diferença é que o ProgressBar mostra, de forma gráfica, quanto falta para o processo ser concluído. Vamos ver esse controle na prática?

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

##### Roteiro da intro
O entry é um dos controles mais comuns entre aplicativos, ele serve como um campo de entrada de texto, pode ser texto comum ou senhas. O entry também é utilizado quando você precisa de textos curtos, para textos longos utilizamos o controle Editor, que veremos no próximo vídeo. Vamos ver o que podemos fazer com o entry?

> #### Capítulo 1.21: Editor
> - Complementa o conteúdo do Entry abordando também o auto size

##### Roteiro da intro
O Editor é um controle para entrada de texto, assim como o entry, porém ele é usado quando tem a intenção de permitir uma grande quantidade de textos, como por exemplo um aplicativo de mensagens. Vamos ver como usar esse controle?

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

##### Roteiro da intro
Um dos controle mais comuns que se tem para exibir coleções de forma customizada. Através desse controle podemos, basicamente, exibir qualquer tipo de coleção em qualquer tipo de layout, esses layouts são exibidos dentro de outro controle, chamado _Cell_, que significa célula em pt-BR, e essa _Cell_ é uma View que pode conter layouts complexos e/ou simples. Vamos dar uma olhada nesse controle?

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

##### Roteiro da intro
O CollectionView é a nova forma de se exibir coleções, é um controle novo introduzido na versão 4.4 do XF. Ele veio para substituir o ListView, com muito mais recursos e funcionalidades. Além de melhorias na performances. Vamos dar uma olhada nele?

> #### Capítulo 1.24: TableView
> - Introdução do TableView
> - Tipos de apresentação
> - Customziações

##### Roteiro da intro
Imagine uma tela de configurações, onde vc tem o título da opção do lado esquerdo e o switch ou checkBox do lado direito. Imaginou? Então esse tipo de layout pode ser facilmente criado com o controle _TableView_. Assim como o controle ListView, este controle utiliza o conceito de células para definir cada item apresentado na tela. Bom chega de imaginar e vamos ver na prática como esse controle funciona.

> #### Capítulo 1.25: CarouselView
> - Conteúdo similar ao ListView e CollectionView, porém, mostrando as diferenças que o CarouselView tem

##### Roteiro da intro
O CarouselView é mais um controle para lidar com coleções, ele é bem similar ao CollectionView. A diferença deste controle está nos casos de uso e como ele exibe as informações. Ele apresenta seu conteúdo de forma horizontal ou vertical, sendo a forma horizontal a mais comum. A ideia principal dele é mostrar um item por vez ao usuário, dando um destaque maior a esse item. Vamos dar uma olhada no CarouselView?

> #### Capítulo 1.26: IndicatorView
> - Utilização do IndicatorView com CarouselView

##### Roteiro da intro
Este controle serve para, basicamente, mostrar ao usuário em qual item ele está de um número definido de itens. Um pouco confuso? Não se preocupe, deixe eu colocar de outra forma, pois provavelmente você já viu esse controle... Lembra do CarouselView? Aquele controle que você coloca uma coleção de itens e ele exibe esses itens na horizontal ou vertical? Então, o IndicatorView é muito utilizado com o CarouselView, normalmente logo abaixo, como bolinhas indicando quantos items a coleção tem e qual índice está sendo exibido para o usuário. O bacana é que o time da XF resolveu criar esse controle separadamente do CarouselView permitindo que você possa utilizá-lo em conjunto com outros controles e/ou layouts. Vamos ver como o IndicatorView funciona?

> #### Capítulo 1.27: BoxView
> - Introdução do BoxView
> - Customização de cor
> - Borda
> - Tamanho

##### Roteiro da intro
O BoxView é um controle primitivo que te permite criar um rentangulo. Parece algo bem "banal" mas ele pode ser útil em diversos cenários, como por exemplo, se vc precisar de criar um separador entre dois controles, você pode utilizar o BoxView com um tamanho definido e cor transparente. Ou se você tem uma lista de itens e precisa colocar uma linha no fim, como separador, você pode utilizar o BoxView com a propridade _Height_ com valor 1. Chega de conversa e vamos esse controle na prática!

> #### Capítulo 1.28: Shapes
> - Introdução do Shapes
> - Line
> - Rectangle
> - Ellipse
> - Path
> - Polygon
> - Polyline

##### Roteiro da intro
O controle de shapes é um dos mais recentes controles do XF, adicionado na versão 4.7. Ele permite criar formas geometricas, simples e complexas de uma maneira _cross-platform_ e através do xaml. Permite também renderizar desenhos em SVG, através de suas coordenadas. Se antes tinhamos apenas o SkiaSharp como solução, para esse tipo de trabalho, agora o Shapes vem se mostrando uma excelente alternativa, em alguns cenários. Vamos dar uma olhada neste controle?

> #### Capítulo 1.29: Propriedades em comum dos controles primitivos
> - Apresentar as propriedades em comum que muitos controles possuem - Translation, Scale, Rotate, Margin, Padding, IsVisible, AutomationId, IsEnable..

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
