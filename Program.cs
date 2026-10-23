// Ficheiro: Program.cs
using System;

namespace LabPilha;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TESTE 1: Inverter Texto");
        string textoInvertido = Laboratorio.inverte("PUCMINAS");
        Console.WriteLine($"Original: PUCMINAS | Invertido: {textoInvertido}");

        Console.WriteLine("TESTE 2: Bubble Sort com Pilhas");
        int[] vetorDesordenado = { 5, 2, 9, 1, 7 };
        int qtdComparacoes;
        
        // Chamada do método modularizado
        int[] vetorOrdenado = Laboratorio.bubblePilhas(vetorDesordenado, out qtdComparacoes);

        Console.WriteLine("Vetor Ordenado:");
        Console.WriteLine(string.Join(", ", vetorOrdenado));
        Console.WriteLine($"Total de Comparações: {qtdComparacoes}");
        Console.WriteLine("TESTE FINAL: Desafio Ordenar Pilha");
        
        // Preparamos uma pilha totalmente desordenada
        Pilha pilhaDesordenada = new Pilha(5);
        pilhaDesordenada.push(3);
        pilhaDesordenada.push(1);
        pilhaDesordenada.push(9);
        pilhaDesordenada.push(5);
        pilhaDesordenada.push(2);

        Console.WriteLine("Pilha Original (Base -> Topo):");
        pilhaDesordenada.mostra();

        Pilha pilhaOrdenada = Laboratorio.ordenaPilha(pilhaDesordenada);

        Console.WriteLine("Pilha Ordenada (Base -> Topo):");
        pilhaOrdenada.mostra(); // Esperado: [1, 2, 3, 5, 9]
    }
}