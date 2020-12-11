using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine ("Digite o Valor da compra");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine(" Selecione o tipo de pagamento:");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            int opcao = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Selecione");





           switch (opcao)
           {
                case 1:
                    //Boleto
                        Boleto boleto = new Boleto();
                        boleto.Valor = valorDaCompra;
                        boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                    break;
                        // Console.WriteLine($"O Valor da compra fica em {boleto.Valor} e a data {boleto.Data}");
                        
                case 2:
                    //Cartão
                    Console.WriteLine(" Selecione o tipo de pagamento:");
                    Console.WriteLine("1 - Cédito");
                    Console.WriteLine("2 - Debito");
                    int tipoCartao = int.Parse(Console.ReadLine());
                    
                        switch (tipoCartao)
                        {
                            case 1:
                            //Crédito
                            Credito credito = new Credito();
                            credito.numero = "123334.123123.123545";
                            credito.bandeira = "MasterCard";
                            credito.cvv = "321";
                            credito.titular =  "Renato Alves de Oliveira";
                            credito.Pagar(valorDaCompra);
                            break;

                            case 2:
                            //Débito
                            break;

                            default:
                            break;
                        }




                    break;
                    default:
                    break;


           }

           

        }
      

    
    }
}
