// ORDENACAO COM SORT
var minhaLista = new List<int> { 10, 5, 6, 7, 3, 1 };
Console.WriteLine("Lista original: " + string.Join(", ", minhaLista));
minhaLista.Sort();
Console.WriteLine("Ordem crescente: " + string.Join(", ", minhaLista));
//minhaLista.Sort((x, y) => y.CompareTo(x));
//Console.WriteLine("Ordem decrescente: " + string.Join(", ", minhaLista));
minhaLista.Sort();
minhaLista.Reverse();
Console.WriteLine("Ordem decrescente: " + string.Join(", ", minhaLista));

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

// ORDENACAO COM LINQ
var cidades = new List<string> {
    "São Paulo",
    "Rio de Janeiro",
    "Brasília",
    "Manaus",
    "Curitiba"
};

Console.WriteLine("Lista original: " + string.Join(", ", cidades));
Console.WriteLine("Ordem crescente: " + string.Join(", ", cidades.OrderBy(x => x)));
Console.WriteLine("Ordem decrescente: " + string.Join(", ", cidades.OrderByDescending(x => x)));


// ORDENACAO DE LISTAS USANDO LINQ COM CHAVE MULTIPLA
var pessoas = new List<dynamic> {
    new { Name = "Cícero", Idade = 32 },
    new { Name = "Maria", Idade = 18 },
    new { Name = "Kiko", Idade = 18 },
    new { Name = "João", Idade = 67 }
};

Console.WriteLine("Lista original: ");
foreach (var pessoa in pessoas)
{
    Console.WriteLine($"{pessoa.Name} tem {pessoa.Idade} anos");
}

Console.WriteLine("");

var pessoasOrdenada = pessoas.OrderBy(x => x.Idade);
foreach (var pessoa in pessoasOrdenada)
{
    Console.WriteLine($"{pessoa.Name} tem {pessoa.Idade} anos");
}

Console.WriteLine("");

var pessoasOrdenada2 = pessoas.OrderBy(x => x.Idade).ThenBy(x => x.Name);
foreach (var pessoa in pessoasOrdenada2)
{
    Console.WriteLine($"{pessoa.Name} tem {pessoa.Idade} anos");
}