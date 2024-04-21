float peso, altura, imc;
string sexo;
do
{
    Console.WriteLine("Digite sua altura (em metros, ex: 1,70)");
    altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu peso em kg (ex: 80,00)");
    peso = float.Parse(Console.ReadLine());
    if (peso <= 0 || altura <= 0 )
    {
        Console.WriteLine("Altura ou peso zerado ou negativo, insira valores validos");
    } 
} while (peso <= 0 || altura <= 0);

do
{
    Console.WriteLine("Digite seu sexo, m para masculino e f para feminino");
    sexo = Console.ReadLine();
    if (sexo != "m" && sexo != "f")
    {
        Console.WriteLine("Valor invalido, repita a operação");
    }
} while (sexo != "m" && sexo != "f");

imc = peso / (altura * altura);

if (sexo == "f" )
{
    if (imc < 19)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else
    {
        if (imc <= 23.9 && imc > 19)
        {
            Console.WriteLine("Normal");
        } else 
        {
            if (imc <= 28.9 && imc > 23.9)
            {
                Console.WriteLine("Obesidade Leve");
            } else
            {
                if (imc <= 38.9 && imc > 28.9)
                {
                    Console.WriteLine("Obesidade Moderada");
                }
                else
                {
                    Console.WriteLine("Obesidade Mórbida");
                }
            }
        }
    }
} else
{
    if (imc < 20)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else
    {
        if (imc < 25 && imc >= 20)
        {
            Console.WriteLine("Normal");
        } else
        {
            if (imc < 30 && imc >= 25)
            {
                Console.WriteLine("Obesidade leve");
            }
            else
            {
                if (imc < 40 && imc >= 30)
                {
                    Console.WriteLine("Obesidade Moderada");
                } else
                {
                    Console.WriteLine("Obesidade Mórbida");
                }
            }
        }
    }
}