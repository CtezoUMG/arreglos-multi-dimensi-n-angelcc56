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
int maximo = numeros[0]; 

// TODO: Implementar el algoritmo de búsqueda aquí
// Recorremos el arreglo
for (int i = 1; i < n; i++)
{
    // Usamos operador ternario
    if (numeros[i] > maximo) maximo = numeros[i];
}

// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(maximo);
