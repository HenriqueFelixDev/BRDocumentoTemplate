# BR Documento Template
Software para a cria��o de modelos de documentos (Templates) que gera automaticamente formul�rios para preenchimento desses modelos. O documento gerado a partir do preenchimento dos formul�rios pode ser impresso ou salvo em formato PDF.

## Como Usar
Na aba **Propriedades**, o usu�rio cria as propriedades que estar�o no modelo e ser�o inseridas dinamicamente no documento. Ap�s criadas, ele pode clicar com o bot�o direito do mouse no campo de texto (RichTextBox), do lado direito da tela, e clicar em uma das propriedades listadas no item de menu **Inserir Propriedade**. 

Ap�s clicar na propriedade, ela � inserida no campo de texto com uma formata��o especial, indicando que � um placeholder. O placeholder � substitu�do pelo valor preenchido no formul�rio ao gerar o documento a partir desse modelo.

Na aba **Formul�rio** ao lado esquerdo do campo de texto � poss�vel preencher os valores das propriedades para gerar um documento a partir do modelo.

Ap�s clicar em **Gerar Documento** na aba **Formul�rio**, uma janela se abre com o documento gerado (placeholders substitu�dos pelos valores do formul�rio).

## Funcionalidades
 - [ ] Cria��o das propriedades (campos) que ser�o inclu�dos no template
 - [ ] Salvamento/Carregamento dos templates criados no sistema de arquivos
 - [ ] Cria��o do formul�rio para preenchimento dos campos de forma din�mica
 - [ ] Cria��o dos placeholders para cada propriedade no RichTextBox.
 - [ ] Cria��o do ContextMenu de inser��o dos placeholders no template.