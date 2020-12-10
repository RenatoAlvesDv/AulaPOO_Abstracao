using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boletos : Pagamentos
    {
         private string codigoDebarras;


         public void Registrar(){
             Console.WriteLine("Registrado");
         }

         public override string Desconto (int valor)
         {
             return "";
         }
    }
}