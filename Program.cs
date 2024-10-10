using Atividade2.Services;

// 1) Criar classe DigitosService dentro do arquivo Services
var digitosService = new DigitosService();

Console.WriteLine("Favor fornecer um numero, para que seja feita a contagem de digitos impares: ");

// 2)   No serviço DigitosService, criar método "int? ObterNumero()"
//      Que lê a entrada do usuário, converte para inteiro, e a retorna.
//      Se não for possível converter em inteiro, retorna nulo
int? numero = digitosService.ObterNumero();

// 3)   No serviço DigitosService, criar método "void PrintDigitosImpares(int numero)"
//      Que imprime na tela a quantidade de dígitos ímpares contidos no número passado
//      como parâmetro. caso o número seja nulo, exibir mensagem de entrada inválida.

// Observação: utilizar apenas operações aritméticas sobre o número passado, não convertê-lo em string.

digitosService.PrintDigitosImpares(numero);