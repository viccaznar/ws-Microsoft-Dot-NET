**Pilha de Chamadas e Painel de Pontos de Interrupção em Depuração**

* **Pilha de Chamadas (Call Stack):**
    * **Função:** Registra a sequência de funções que foram chamadas no programa até o momento em que a execução é pausada (ou ocorre um erro). É o "rastro" das chamadas de função.
    * **Rastreamento de Pilha (Stack Trace):** É o texto que aparece junto com mensagens de erro (exceções), listando as funções que levaram ao erro, incluindo funções internas do .NET.
    * **Painel "Pilha de Chamadas" (VS Code):** Uma ferramenta visual que **filtra informações irrelevantes** do runtime do .NET, mostrando apenas as funções do seu próprio código. Isso facilita a localização da origem de uma exceção.

* **Painel Pontos de Interrupção (Breakpoints Panel):**
    * **Função:** Uma visão centralizada de **todos os pontos de interrupção** que você definiu em seu código.
    * **Controle:** Permite habilitar/desabilitar pontos de interrupção facilmente.
    * **Exceções:** Oferece opções para pausar o programa automaticamente quando ocorrem **exceções capturadas ou não capturadas**.
    * **Integração:** Trabalha em conjunto com a Pilha de Chamadas para examinar o estado do programa e rastrear a causa de erros.

---

**Exemplo Lúdico: A Investigação do Crime na Mansão e a Central de Monitoramento**

Imagine que seu programa é uma **mansão com vários mordomos e criadas (funções)**, e você é um detetive investigando um "crime" (um bug ou exceção).

* **O "Caminho do Crime" (Pilha de Chamadas):** Quando algo dá errado, você precisa saber **quem estava fazendo o quê e onde, antes do incidente**. A Pilha de Chamadas é como um **registro detalhado do caminho** que os personagens fizeram até o momento do crime: "O mordomo foi à cozinha, depois à sala, depois ao quarto, e lá o crime aconteceu."

    * O "rastreamento de pilha" na cena do crime é como um relatório confuso que inclui até os movimentos de baratas e ratos na mansão (funções internas do .NET).
    * O **Painel "Pilha de Chamadas"** é como um **mapa simplificado da mansão** que só mostra os movimentos dos seus mordomos e criadas (seu código), ignorando as baratas, para você focar em quem importa e descobrir onde o crime realmente começou.

* **A Central de Monitoramento (Painel Pontos de Interrupção):** Você tem uma central onde controla todas as suas "câmeras de segurança" (pontos de interrupção) espalhadas pela mansão.

    * Nessa central, você vê todas as câmeras ativas e pode ligá-las ou desligá-las.
    * Você também tem alarmes configurados para disparar e pausar tudo **se um vaso for quebrado** (exceções capturadas) ou **se alguém sumir sem deixar rastros** (exceções não capturadas).
    * Ao combinar o controle das câmeras (Pontos de Interrupção) com o mapa do caminho do crime (Pilha de Chamadas), você consegue montar o quebra-cabeça e pegar o culpado (o bug)!

Essas ferramentas são essenciais para você, o detetive, conseguir entender a sequência de eventos que leva a um problema no seu código e encontrar a raiz do mistério.