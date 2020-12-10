using System;

namespace AulaPOO_Abstracao.classes
{
     public abstract class Pagamentos
    {

        //Atributos
       private DateTime data;


       protected float valor;



        //Métodos
       public string Cancelar(){
           return "";
       }
      

      //Obrigatorio
       public abstract string Desconto (int valor);
    }
}