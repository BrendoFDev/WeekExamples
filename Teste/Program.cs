bool infinito = true;

while (infinito) { 

    Console.WriteLine("[1] Calcular IMC \n[2] Calcular idade");
    string choice = Console.ReadLine()!;

    if (choice =="1")
        CalcIMC();
    if (choice == "2")
        CalcAge();

    StopApplication();
}

Thread.Sleep(10000);

void StopApplication()
{
    Console.WriteLine("Você deseja parar? ");
    string choice = Console.ReadLine()!;

    if (choice.ToLower() == "sim")
        infinito = false;
}

void CalcIMC()
{
    Console.WriteLine("Escreva a sua altura em cm  ");
    int altura = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escreva seu peso em KG  ");
    float peso = float.Parse(Console.ReadLine()!); ; //! p dizer que existe

    double imc = peso / (altura * altura);
    Console.WriteLine($"Seu IMC é  {imc}");
}

void CalcAge()
{
    Console.WriteLine("Escreva o seu ano de nascimento  ");
    int ano_nasc = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escreva o ano atual  ");
    int ano_atual = Convert.ToInt32(Console.ReadLine());

    var idade = ano_atual - ano_nasc;
    Console.WriteLine("Sua idade é " + idade);
}