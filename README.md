# Respostas Teóricas - Laboratório TAD Pilha
### Aluno: Lucas Henrique Pereira Silva
### Matrícula: 879364

## Parte 2:

| Operação | Retorno | Pilha (base -> topo) | topo |
| :--- | :--- | :--- | :--- |
| `empilha(10)` | | `[10]` | 1 |
| `empilha(20)` | | `[10, 20]` | 2 |
| `desempilha()` | 20 | `[10]` | 1 |
| `empilha(30)` | | `[10, 30]` | 2 |
| `empilha(40)` | | `[10, 30, 40]` | 3 |
| `desempilha()` | 40 | `[10, 30]` | 2 |
| `desempilha()` | 30 | `[10]` | 1 |
| `empilha(50)` | | `[10, 50]` | 2 |

---

## Parte 4.1

Vetor inicial `{5, 2, 9, 1, 7}`, o valor 7 é o topo.

| Passada | carry final | B (base -> topo) | R (base -> topo) |
| :--- | :--- | :--- | :--- |
| 1 | 9 | `[1, 7, 2, 5]` | `[9]` |
| 2 | 7 | `[2, 5, 1]` | `[9, 7]` |
| 3 | 5 | `[1, 2]` | `[9, 7, 5]` |
| 4 | 2 | `[1]` | `[9, 7, 5, 2]` |
| 5 | 1 | `[]` | `[9, 7, 5, 2, 1]` |

---

## Parte 4.3

**a)** Para um vetor de **n = 5**, foram feitas 10 comparações ao total (sendo 4 na primeira passada, 3 na segunda, 2 na terceira e 1 na última). A expressão geral para o número de comparações em função de **n** é calculada por **n * (n - 1) / 2**. Este número é exatamente igual ao comportamento do Bubble Sort implementado num vetor sem verificações de otimização.

**b)** O custo extra é de **O(N)** em espaço de memória. Enquanto o Bubble Sort clássico ordena elemento por elemento, este método com pilhas exige a criação e manutenção simultânea de três estruturas completas do tamanho de **N** (Pilhas A, B e R), consumindo o triplo da memória base da aplicação.

**c)** Perdemos o acesso direto aos índices (ou seja, não podemos simplesmente ir a uma posição específica usando `v[i]`). Para resolver isso, o código precisa "desempilhar" os números um a um e guardá-los numa pilha de rascunho (Pilha B) até chegar ao elemento que queremos testar. É como procurar um livro que está no fundo de uma caixa: tens de tirar todos os que estão por cima primeiro para conseguires chegar à base.

**d)** No mercado de trabalho real, não vale a pena. Ficar empilhando e desempilhando dados o tempo todo gasta o triplo da memória e deixa o programa muito mais lento do que se usássemos um vetor normal. Por fim, ordenar pilhas não vale a pena quando há maneiras muito mais práticas e baratas de se fazer.
