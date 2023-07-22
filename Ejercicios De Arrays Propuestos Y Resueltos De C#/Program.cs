// ******************** Ejercicios De Arrays Propuestos Y Resueltos De C# ********************


// 1)Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.

int[] array = { 21, 52, 43, 334, 52, 36, 71, 18, 69, 910 };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array[i], i);
}

// 2)Crea un array de 10 posiciones, pide los valores por consola y muestra el array.

int[] array2 = new int[10];


for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine("Escribe un numero para la posicion: {0}", i);
    int num = int.Parse(Console.ReadLine());
    array2[i] = num;
}


Console.WriteLine("Datos del array");
for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array2[i], i);
}

// 3)Sumar los valores de un array y mostrar el resultado.


Console.WriteLine("Ingrese la cantidad de posiciones que desea que tenga el array");
int position3 = int.Parse(Console.ReadLine());

int[] array3 = new int[position3];
int Suma = 0;


for (int i = 0; i < array3.Length; i++)
{
    Console.WriteLine("Escribe un numero para la posicion: {0}", i);
    int num = int.Parse(Console.ReadLine());
    array3[i] = num;
}


Console.WriteLine("\nDatos del array");
for (int i = 0; i < array3.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array3[i], i);
    Suma += array3[i];
}

Console.WriteLine("\nLa suma del array es: {0}", Suma);


// 4)Hacer la media de los valores de un array y mostrar el resultado.


Console.WriteLine("Ingrese la cantidad de posiciones que desea que tenga el array");
int position4 = int.Parse(Console.ReadLine());

int[] array4 = new int[position4];
int Suma4 = 0;
int media4 = 0;

for (int i = 0; i < array4.Length; i++)
{
    Console.WriteLine("Escribe un numero para la posicion: {0}", i);
    int num4 = int.Parse(Console.ReadLine());
    array4[i] = num4;
}


Console.WriteLine("\nDatos del array");
for (int i = 0; i < array4.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array4[i], i);
    Suma += array4[i];

    media4 = Suma4 / array4.Length;
}

Console.WriteLine("\nLa media del array es: {0}", media4);


// 5)Pedir un numero por teclado y multiplicar todos los valores de un array y mostrar el array.

Console.WriteLine("Ingrese la cantidad de posiciones que desea que tenga el array");
int position5 = int.Parse(Console.ReadLine());

int[] array5 = new int[position5];

for (int i = 0; i < array5.Length; i++)
{
    Console.WriteLine("Escribe un numero para la posicion: {0}", i);
    int num5 = int.Parse(Console.ReadLine());
    array5[i] = num5;
}


Console.WriteLine("\nDatos del array");
for (int i = 0; i < array5.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array5[i], i);
}

int producto5 = array5.Aggregate((x, y) => x * y);

Console.WriteLine("\nLa multiplicacion del arreglo es: {0}", producto5);


// 6)Dado un array de numeros con el metodo Sort, ordenalos y muestra su contenido.


Console.WriteLine("Ingrese la cantidad de posiciones que desea que tenga el array");
int position6 = int.Parse(Console.ReadLine());

int[] array6 = new int[position6];

for (int i = 0; i < array6.Length; i++)
{
    Console.WriteLine("Escribe un numero para la posicion: {0}", i);
    int num6 = int.Parse(Console.ReadLine());
    array6[i] = num6;
}


Console.WriteLine("\nDatos del array");
for (int i = 0; i < array6.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array6[i], i);
}


Array.Sort(array6);
Console.WriteLine("\nDatos del array en Orden");
for (int i = 0; i < array6.Length; i++)
{
    Console.WriteLine("El numero {0} ", array6[i]);
}
Console.ReadLine();

// 7)Dado un array de números, muestra el mayor y el menor.


Console.WriteLine("Ingrese la cantidad de posiciones que desea que tenga el array");
int position7 = int.Parse(Console.ReadLine());

int[] array7 = new int[position7];

for (int i = 0; i < array7.Length; i++)
{
    Console.WriteLine("Escribe un numero para la posicion: {0}", i);
    int num7 = int.Parse(Console.ReadLine());
    array7[i] = num7;
}


Console.WriteLine("\nDatos del array");
for (int i = 0; i < array7.Length; i++)
{
    Console.WriteLine("El numero {0} esta en la posicion {1}", array7[i], i);
}


Array.Sort(array7);
Console.WriteLine("\nEl numero menor es {0}", array7[0]);
Console.WriteLine("El numero mayor es {0}", array7[(array7.Length - 1)]);