//Esse código valida a entrada de inteiro, necessitando converter uma string para inteiro.
//Ele utiliza o loop do-while para validar as condições: 
// o numero deve ser inteiro entre 5 e 10, não pode ser uma string.


int? numero;                             //Declarando a variável numero do tipo anulável.

do
{
    Console.WriteLine("Digite um número inteiro entre 5 e 10: ");
    string input = Console.ReadLine();  //Declarando a string input que irá receber valor do user.

    if (int.TryParse(input, out int result)) //SE conseguir converter a string para um numero inteiro,
    {                                        // irá armazenar na variável criada aqui, int result.
        numero = result;   //Atribuindo o valor convertido na variavel result na variável numero.
    }
    else
    {
        numero = null;     //SE não conseguir converter, a variavel numero continua como nula 
    }                      // e o loop irá repetir.

} while (numero == null);  //Enquanto o numero for nulo, o loop irá repetir.

if (numero < 5 || numero > 10)
{
    Console.WriteLine("Desculpe, você digitou um número inválido, tente novamente.");
}
else
{
    Console.WriteLine($"Seu valor de entrada {numero} foi aceito.");
}



