# 🚀 Editor de Grafos com C\# e Windows Forms

### 1\. 📝 Resumo do Projeto

Editor de Grafos é uma aplicação desktop desenvolvida em **C\# .NET com Windows Forms**, criada como uma ferramenta visual para o estudo e experimentação de algoritmos e estruturas de dados de grafos.

O software permite que o usuário crie, manipule e visualize grafos de forma intuitiva, além de executar diversos algoritmas clássicos sobre a estrutura de dados criada. Este projeto foi desenvolvido como parte da disciplina de Algoritmos e Estruturas de Dados II.

### 2\. ✨ Funcionalidades Principais

  * **Criação Visual:** Adicione, mova e conecte vértices diretamente na interface com o mouse.
  * **Grafos Ponderados:** Atribua pesos às arestas e exiba-os na tela.
  * **Salvamento e Carregamento:** Salve o estado de um grafo em um arquivo e carregue-o posteriormente.
  * **Execução de Algoritmos:** Calcule e exiba resultados de algoritmos de teoria dos grafos, como:
      * Verificação de Grafo Euleriano
      * Verificação de Grafo Unicursal
      * Geração de Pares Ordenados
      * Completar um Grafo

### 3\. 🛠️ Conceitos Técnicos Demonstrados

Este projeto é uma demonstração prática das seguintes habilidades e conceitos:

  * **⚡ Controles Personalizados (Custom Controls):** A classe `Vertice` herda de `System.Windows.Forms.Control`, transformando um conceito de dados em um componente de UI interativo e reutilizável.
  * **🎨 Renderização Gráfica (GDI+):** Utilização do evento `OnPaint` e da biblioteca `System.Drawing` para desenhar os vértices e as arestas dinamicamente no formulário, demonstrando controle sobre o pipeline de renderização.
  * **🖱️ Manipulação de Eventos:** Gerenciamento avançado de eventos de mouse (`OnMouseDown`, `OnMouseMove`, `OnClick`) para implementar funcionalidades de arrastar e soltar (`drag-and-drop`) e interações complexas com os vértices.
  * **🏛️ Design Orientado a Objetos (OOP):**
      * **Separação de Responsabilidades:** Classes bem definidas como `Editor`, `Grafo`, `Vertice` e `Aresta`, cada uma com um propósito claro.
      * **Uso de Interfaces:** A interface `iGrafo` define um contrato claro para os algoritmos, promovendo um design de baixo acoplamento e facilitando a extensibilidade.
  * **💾 Serialização e I/O de Arquivos:** Implementação de funcionalidades para salvar e carregar a estrutura de dados do grafo em arquivos físicos.
  * **🧠 Algoritmos e Estrutura de Dados:** Aplicação prática de algoritmos de teoria dos grafos sobre uma estrutura de dados customizada.

### 4\. 💻 Tecnologias Utilizadas

  * **C\#**
  * **.NET Framework**
  * **Windows Forms (WinForms)**
  * [cite\_start]**Visual Studio** [cite: 2]

### 5\. ▶️ Como Executar o Projeto

1.  **Pré-requisitos:**

      * [cite\_start]Microsoft Visual Studio (com suporte a .NET Framework). [cite: 2]

2.  **Clone o repositório:**

    ```bash
    git clone https://github.com/seu-usuario/editor-grafos.git
    ```

3.  **Abra no Visual Studio:**

      * [cite\_start]Navegue até a pasta do projeto e abra o arquivo de solução `Editor de Grafos.sln`. [cite: 2]

4.  **Execute:**

      * Pressione `F5` ou clique no botão "Start" para compilar e rodar a aplicação. O Visual Studio se encarregará de restaurar as dependências necessárias.
