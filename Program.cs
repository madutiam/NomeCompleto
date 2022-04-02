string nome, sobrenome, SOBRENOME;

Console.Write("Digite seu primeiro nome: ");
nome=Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
sobrenome=Console.ReadLine()!;

SOBRENOME=sobrenome.ToUpper();

Console.WriteLine($"Nome completo: {nome} {sobrenome}"!);
Console.WriteLine($"Nome de catalogo: {SOBRENOME} {nome} "!);
