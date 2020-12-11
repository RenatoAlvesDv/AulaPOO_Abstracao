using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamentos
    {
         private string codigoDebarras = "1234566.123264484.15198455.1265656";
         public string CodigoDeBarras{
             get{return codigoDebarras;}
         }

         public void Registrar(float valor, DateTime dataEmissao, string codigoDeBarras){
             
             Console.WriteLine($"O valor da compra fica em R${valor*0.88f}");
             Console.WriteLine($"A Data de emissão = {dataEmissao}");
             Console.WriteLine($"Data de Vencimento = {dataEmissao.AddDays(10)}");
             Console.WriteLine($"Código de Barras ={codigoDeBarras}");
         }

        
         
    }
}