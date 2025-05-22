**Criar Funcionalidades em .NET: O Fluxo de Trabalho**

* **Escrevendo a Lógica do Aplicativo:**
    * Desenvolvedores começam a escrever o código específico para o que o aplicativo deve fazer.
    * **Referência a Bibliotecas de Código:** Para tarefas especializadas (ex: conectar-se à internet, acessar bancos de dados, converter dados, registrar eventos para diagnóstico), referenciam e usam bibliotecas de código existentes.
        * Algumas bibliotecas já vêm com o **SDK do .NET**.
        * Outras são obtidas via **NuGet** (um gerenciador de pacotes) usando o Visual Studio ou a .NET CLI.

* **Compilar e Executar o Aplicativo:**
    * É um processo frequente: o código é compilado e executado para verificar o funcionamento e identificar o que precisa ser ajustado.
    * **Erros de Compilação:** Ocorrem quando o código não segue as regras da linguagem (erros de sintaxe). O compilador impede a execução até que sejam corrigidos.
    * **Erros de Runtime (Exceções):** Acontecem quando a lógica do programa está incorreta e impede a execução durante o uso. O aplicativo "trava".
    * **Erros Lógicos Silenciosos:** Alguns erros não causam falhas, mas produzem resultados inesperados. São corrigidos através de **testes e depuração**.

---

**Exemplo Lúdico: A Construção de um Robô com um Manual e um Avaliador de Qualidade**

Imagine que você está construindo um robô com muitas funções novas.

* **Escrevendo as Novas Funções (Lógica do Aplicativo):** Você começa a escrever as instruções para o seu robô fazer coisas novas, como "dançar" ou "preparar café".
    * **Pegando Peças Prontas (Referências a Bibliotecas):** Para tarefas complexas, como conectar-se ao Wi-Fi ou reconhecer rostos, você não constrói tudo do zero. Você pega "módulos prontos" (bibliotecas de código) que já vêm com o kit básico do robô (SDK do .NET) ou compra módulos especializados em uma loja de eletrônicos (NuGet). Você só precisa encaixá-los e dizer ao robô para usá-los.

* **Montando e Testando o Robô (Compilar e Executar):** À medida que adiciona novas funções, você monta e liga o robô com frequência para ver se funciona.
    * **Erros no Manual (Erros de Compilação):** Se você escrever uma instrução de montagem de forma errada, como "conectar o fio azul no buraco quadrado", o robô (compilador) simplesmente para e diz: "Erro no manual! Não consigo entender isso!". Você precisa corrigir a instrução antes que ele continue.
    * **O Robô Trava (Erros de Runtime/Exceções):** Se a instrução for "pular de um prédio", o manual está sintaticamente correto, mas a lógica é falha. Quando o robô tenta executar, ele "trava" e desliga porque a ação é impossível ou perigosa.
    * **Resultados Inesperados:** Às vezes, o robô faz algo, mas não exatamente o que você esperava. Ele "prepara café", mas o café está frio. Não travou, mas a lógica da temperatura está errada. Você precisa **testar** todas as funções e **depurar** (investigar) onde o erro lógico aconteceu para corrigi-lo.

Esse processo de escrever, montar e testar repetidamente é essencial para garantir que seu robô (aplicativo) funcione perfeitamente.