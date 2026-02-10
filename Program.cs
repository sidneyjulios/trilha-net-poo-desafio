using System.ComponentModel;
using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

int Opcao = 0;
int quantidadeMemoria;
string numeroImei;
string tipoModelo;
string instalarAplicativo;
bool VerificaOpcao = false;





Console.WriteLine("Informe qual aparelho deseja utilizar:\nOpção 1 Nokia \nOpção 2 Iphone");
Opcao = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(Opcao);

if (Opcao == 1)
{
    Console.WriteLine("Informe o modelo: ");
    tipoModelo = Console.ReadLine();

    Console.WriteLine("Informe o Nº do Imei: ");
    numeroImei = Console.ReadLine();

    Console.WriteLine("Informe a quantidade de memoria: ");
    quantidadeMemoria = Convert.ToInt32(Console.ReadLine());

    Smartphone nokia = new Nokia(numero: "123456", modelo: tipoModelo, imei: numeroImei, memoria: quantidadeMemoria);

    Console.WriteLine();

    Console.WriteLine("Informe qual opção deseja executar: \nOpção 1 ligar e instalar aplicativo \nOpção 2 Receber ligação" );

    Opcao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    switch(Opcao)
    {
        case 1:
            nokia.Ligar();
            Console.WriteLine("Aparelho Nokia");
            Console.WriteLine("Informe o aplicativo que deseja instalar");
            instalarAplicativo = Console.ReadLine();
            nokia.InstalarAplicativo(instalarAplicativo);
            break;
        case 2:
            Console.WriteLine("Aparelho Nokia");
            nokia.ReceberLigacao();
            break;
        default:
            Console.WriteLine("Aparelho Nokia");
            Console.WriteLine("Encerrando");
            break;    
        }
    }

else
{
    Console.WriteLine("Informe o modelo: ");
    tipoModelo = Console.ReadLine();

    Console.WriteLine("Informe o Nº do Imei: ");
    numeroImei = Console.ReadLine();

    Console.WriteLine("Informe a quantidade de memoria: ");
    quantidadeMemoria = Convert.ToInt32(Console.ReadLine());

    Smartphone iphone = new Iphone(numero: "123456", modelo: tipoModelo, imei: numeroImei, memoria: quantidadeMemoria);

    Console.WriteLine();

    Console.WriteLine("Informe qual opção deseja executar: \nOpção 1 ligar e instalar aplicativo \nOpção 2 Receber ligação" );

    Opcao = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    switch(Opcao)
        {
            case 1:
                iphone.Ligar();
                Console.WriteLine("Aparelho Iphone");
                Console.WriteLine("Informe o aplicativo que deseja instalar");
                instalarAplicativo = Console.ReadLine();
                iphone.InstalarAplicativo(instalarAplicativo);
                break;
            case 2:
                Console.WriteLine("Aparelho Iphone");
                iphone.ReceberLigacao();
                break;
            default:
                Console.WriteLine("Aparelho Iphone");
                Console.WriteLine("Encerrando");
                break;    
        }   
        
    }


