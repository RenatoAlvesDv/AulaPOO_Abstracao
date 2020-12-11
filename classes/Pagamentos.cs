using System;

namespace AulaPOO_Abstracao.classes
{
     public abstract class Pagamentos
    {

        //Atributos
       private DateTime data;

       public DateTime Data{
           get {return data;}
           set{data = value;}
       }


       protected float valor;

         public float Valor{
             set{valor = value;}
             get{return valor;}
        }

        //Métodos
       public string Cancelar(){
           return "";
       }
      

    //   //Obrigatorio
    //    public abstract string Desconto (int valor);
    }
}