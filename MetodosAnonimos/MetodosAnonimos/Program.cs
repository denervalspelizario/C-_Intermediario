// See https://aka.ms/new-console-template for more information
Console.WriteLine("Métodos Anonimos");

// criando o metodo - sintaxe do método anonimo
Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método Anônimo : {valor}");
};


// chamando o metodo

imprimir(100);
imprimir(200);

Console.ReadKey();




// criando o delegate
public delegate void Imprimir(int valor);