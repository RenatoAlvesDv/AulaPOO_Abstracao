using System;

namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public void Pagar (float valor){
    
            if(valor <= this.limite){
                // Efetuar pagamento 
                int parcelas;
                do{
                    Console.WriteLine("Selecione a quantidade de parcelas de 1 a 12:"); 
                    parcelas = int.Parse(Console.ReadLine());
                }while(parcelas >12);

                float juros;
                if(parcelas <= 6){
                    juros = 0.05f;
                }else{
                    juros= 0.08f;
                }

                float total = valor + (valor * juros);
                this.Valor = total;

                ExibirNotas(this.titular, total);

            }else{
                Console.WriteLine("Sem limite!");
            }
        }
        public void ExibirNotas( string titular, float total){
            Console.WriteLine($"Titular {titular} - Valor da compra = {total}");
        }
    }
}