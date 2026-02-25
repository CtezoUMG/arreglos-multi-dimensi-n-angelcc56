using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;

int n = int.Parse(linea1);
// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO ---
// Instrucción: El alumno debe encontrar el valor máximo del arreglo 'numeros'
Span<int> span = numeros.AsSpan();
int maximo = span[0];
int indice = 1;
int length = span.Length;

// Procesamos de 4 en 4
while (indice <= length - 4)
{
    if (span[indice] > maximo) maximo = span[indice];
    if (span[indice + 1] > maximo) maximo = span[indice + 1];
    if (span[indice + 2] > maximo) maximo = span[indice + 2];
    if (span[indice + 3] > maximo) maximo = span[indice + 3];
    indice += 4;
}

while (indice < length)
{
    if (span[indice] > maximo) maximo = span[indice];
    indice++;
}
// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(maximo);
