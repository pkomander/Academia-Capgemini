# Academia-Capgemini

Desafio de programação academia Capgemini.

Feito utilizando a linguagem C#, portanto o programa deve ser executato utilizando o Visual Studio, em qualquer versão disponivel.

Total de questões 3.

primeira questão:
Escreva um algoritmo que mostre na tela uma escada de tamanho n utilizando o caractere * e espaços. A base e altura da escada devem ser iguais ao valor de n. A última linha não deve conter nenhum espaço.
Exemplo:
Entrada:
n = 6

Saída:

R = Expliação - para concluir a primeira atividade foi criado lista de icones passando o numero total de n = 6, com um for aninhado interando o icone em um string.



Segunda Questão:
Débora se inscreveu em uma rede social para se manter em contato com seus amigos. A página de cadastro exigia o preenchimento dos campos de nome e senha, porém a senha precisa ser forte. O site considera uma senha forte quando ela satisfaz os seguintes critérios:
Possui no mínimo 6 caracteres.
Contém no mínimo 1 dígito.
Contém no mínimo 1 letra em minúsculo.
Contém no mínimo 1 letra em maiúsculo.
Contém no mínimo 1 caractere especial. Os caracteres especiais são: !@#$%^&*()-+
Débora digitou uma string aleatória no campo de senha, porém ela não tem certeza se é uma senha forte. Para ajudar Débora, construa um algoritmo que informe qual é o número mínimo de caracteres que devem ser adicionados para uma string qualquer ser considerada segura.

Exemplo:
Entrada:
Ya3


Saída:
3

R = Explicação - para a segunda atividade foi utilizado o modelo de validação Regex, criando um metodo onde poderia verificar se continha Caracteres: maiusculos e minusculos, numeros, e caracteres especiais, caso apresente algum erro na senha sera retornado o motivo da não validação da senha.




Terceira Questão
Duas palavras podem ser consideradas anagramas de si mesmas se as letras de uma palavra podem ser realocadas para formar a outra palavra. Dada uma string qualquer, desenvolva um algoritmo que encontre o número de pares de substrings que são anagramas.
Exemplo:
Exemplo 1)
Entrada:
ovo

Saída:
2

Explicação:
A lista de todos os anagramas pares são: [o, o], [ov, vo] que estão nas posições [[0], [2]], [[0, 1], [1, 2]] respectivamente. 

Exemplo 2)
Entrada:
ifailuhkqq

Saída:
3


R = Explicação - para concluir essa etapa primeiro foi criado uma variavel com o valor total em tamanho para uma string 256, aplidando o tamanho padrão foi criada dois metodos um para buscar pelos indices que contem caracteres similares por meio de dois loops for onde o primeiro contem a informação do tamanho das strings e o segundo itera as duas variaveis e movendo para o metodo Comparar para verificar se há valores similares retornando o numero da interação onde o elemento foi encontrado.
