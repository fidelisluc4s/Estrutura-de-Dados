# Estrutura-de-Dados



Veja abaixo um exemplo de algoritmo iterativo para cálculo dos divisores de um número natural.

Seguindo os cinco passos para transformar esse procedimento em um procedimento recursivo, temos:

Passo 1: Substitua o comando for ou o comando do..while pelo comando while.

Passo 2: Altere a sub-rotina para passar a receber por parâmetro o valor a ser processado.

Passo 3: Substitua o comando de atualização da variável de controle do comando while pela chamada recursiva passando por parâmetro o próximo valor dessa variável.

Passo 4: Substitua o comando while por um comando if.

Passo 5: Crie uma função empacotadora para fazer a primeira chamada à sub-rotina recursiva.

Passo 6: Se você não quiser criar a sub-rotina empacotadora, em C# você pode definir o valor padrão para um argumento de uma sub-rotina se o mesmo não for passado. Adicionando o valor 1 como padrão para o argumento divisor da nossa função, ao não passarmos esse parâmetro, será assumido o valor 1 para o mesmo. Dessa forma, podemos chamar a função passando apenas o valor para o parâmetro chamado numero e deixando o parâmetro chamado divisor ser passado somente nas chamadas recursivas. Veja o único procedimento abaixo.
