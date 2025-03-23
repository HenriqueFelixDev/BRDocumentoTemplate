# BR Documento Template
Software para a criação de modelos de documentos (Templates) que gera automaticamente formulários para preenchimento desses modelos. O documento gerado a partir do preenchimento dos formulários pode ser impresso ou salvo em formato PDF.

## Como Usar
Na aba **Propriedades**, o usuário cria as propriedades que estarão no modelo e serão inseridas dinamicamente no documento. Após criadas, ele pode clicar com o botão direito do mouse no campo de texto (RichTextBox), do lado direito da tela, e clicar em uma das propriedades listadas no item de menu **Inserir Propriedade**. 

Após clicar na propriedade, ela é inserida no campo de texto com uma formatação especial, indicando que é um placeholder. O placeholder é substituído pelo valor preenchido no formulário ao gerar o documento a partir desse modelo.

Na aba **Formulário** ao lado esquerdo do campo de texto é possível preencher os valores das propriedades para gerar um documento a partir do modelo.

Após clicar em **Gerar Documento** na aba **Formulário**, uma janela se abre com o documento gerado (placeholders substituídos pelos valores do formulário).

## Funcionalidades
 - [ ] Criação das propriedades (campos) que serão incluídos no template
 - [ ] Salvamento/Carregamento dos templates criados no sistema de arquivos
 - [ ] Criação do formulário para preenchimento dos campos de forma dinâmica
 - [ ] Criação dos placeholders para cada propriedade no RichTextBox.
 - [ ] Criação do ContextMenu de inserção dos placeholders no template.