// Pega a idade da pessoa
int idade;
Console.Write("Informe sua idade: ");
int.TryParse(Console.ReadLine(), out idade); //Como a varável idade não tem valor, essa linha do código pega o que a pessoa informou na linha de Escreva sua idade pega e transforma em int, e a variável idade passa ter um valor

//Pega o nome da pessoa
string nome;
Console.Write("Qual seu nome?: "); //Quando é string, não é necessário fazer a conversão

//Pega o sexo da pessoa
char sexo;
Console.Write("Informe seu sexo: (M ou F)");
char.TryParse(Console.ReadLine(), out sexo);

if(sexo == 'F' && idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Você tem {idade} anos e é do gênero {sexo}, então pode entrar");
}


Console.ReadKey();