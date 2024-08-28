// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor 
// e ordenar do menor para o maior.
// 1. Desenvolver o algoritmo de ordenação (Bubble Sort);
// 2. Utilizar uma função em C# para ordenação;

// passos
// 1 - criar um vetor de valores inteiros
int tamanho = 100;
int[] vetor = new int[tamanho];

// 2 - percorrer o vetor com um laço
Random random = new Random();
for (int i = 0; i < vetor.Length; i++) {
    // 3 - gerar um valor aleatorio em C#
    vetor[i] = random.Next(1000);
}

// 4 - imprimir o vetor com valores aleatorios
Console.Write("Vetor desordenado: ");
for (int i = 0; i < vetor.Length; i++) {
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.WriteLine("\n");

// 6 - imprimir o vetor com valores ordenados
Console.Write("Vetor ordenado: ");
for (int i = 0; i < vetor.Length; i++) {
    Console.Write(vetor[i] + " ");
}
