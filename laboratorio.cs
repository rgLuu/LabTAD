using System;

namespace LabPilha;

public static class Laboratorio
{
    // parte de inverter texto
    public static string inverte(string s)
    {
        Pilha p = new Pilha(s.Length);
        
        foreach (char letra in s)
        {
            p.push((int)letra);
        }

        string resultado = "";
        while (!p.vazia())
        {
            resultado += (char)p.pop();
        }

        return resultado;
    }

    // parte de bubble sort com pilha
    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        comparacoes = 0;
        int n = v.Length;
        
        Pilha A = new Pilha(n);
        Pilha B = new Pilha(n);
        Pilha R = new Pilha(n);

        for (int i = 0; i < n; i++) A.push(v[i]);

        for (int restantes = n; restantes >= 1; restantes--)
        {
            int carry = A.pop();

            for (int i = 0; i < restantes - 1; i++)
            {
                int x = A.pop();
                comparacoes++; 

                if (carry > x)
                {
                    B.push(x);
                }
                else
                {
                    B.push(carry);
                    carry = x;        
                }
            }
            
            R.push(carry);
            
            Pilha temp = A;
            A = B;
            B = temp;
        }

        int[] vetorOrdenado = new int[n];
        for (int i = 0; i < n; i++)
        {
            vetorOrdenado[i] = R.pop();
        }

        return vetorOrdenado;
    }
    // parte de ordenar pilha
    public static Pilha ordenaPilha(Pilha p)
    {
        Pilha auxiliar = new Pilha(p.tamanho());

        while (!p.vazia())
        {
            int temp = p.pop();

            while (!auxiliar.vazia() && auxiliar.consultaTopo() > temp)
            {
                p.push(auxiliar.pop());
            }

            auxiliar.push(temp);
        }

        return auxiliar;
    }
}