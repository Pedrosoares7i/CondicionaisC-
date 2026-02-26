string[] diaSemana = new string[]
{
    "Segunda-Feira",
    "Terça-Feira",
    "Quarta-Feira",
    "Quinta-Feira",
    "Sexta-Feira"
};

for (int i = 0; i < diaSemana.Length; i++)
{
    Console.WriteLine(diaSemana[i]); // Console.Write aparece o resultado todo na mesma linha.
                                     // Já o Console.WriteLine o resultado com quebra de linha
}
Console.ReadKey(); //Mantém o terminal aberto