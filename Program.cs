using System;

namespace Tombola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto a Tombola!");
            int numero;
            sceltaDeiNumeri();
            Console.WriteLine("I numeri scelti dal pc sono:");
            estrazioneNumeri();
            //controlloVittoria();
            
            void sceltaDeiNumeri(){
                int[] numUtente = new int[15];
                Console.WriteLine("Inserisci 15 numeri tra 1 e 90, tutti diversi.");
                
                for (int i=0; i < numUtente.Length; i++)
                {
                    Console.WriteLine((i + 1) + "- Numero:");
                    numero = Convert.ToInt32(Console.ReadLine());
          
                for (int u = 0; u < numUtente.Length - 1; u++)
                    {
                        if ((numero == numUtente[u]) || (numero<1) || (numero>90))
                            {
                                Console.WriteLine("Parametri sbagliati, riscrivi il "+(i+1)+" numero");
                                numero = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    numUtente[i] = numero;

                }
                Console.WriteLine("I numeri da te scelti sono:");
                for (int u = 0; u < numUtente.Length; u++)
                {
                    Console.WriteLine(numUtente[u] + " ");
                }
            }
            
            void estrazioneNumeri(){
                int[] numPc = new int[70];
                Random x = new Random();
                for(int i=0; i<numPc.Length; i++)
                {
                    numPc[i] = x.Next(1, 91);
                    Console.WriteLine((i+1)+"- " + numPc[i]);
                    for (int u = 0; u <= numPc.Length; u++)
                    {
                        if (numPc[i] == numPc[u])
                        {
                            break;
                           
                        }
                    }
                }
            }

            //void controlloVittoria(){    ---->Fare 2 cicli -->Ogni numero che ha inserito l'utente lo ricerco nell'array dei numeri del
                                            //pc: ogni numero che trovo lo inserisco in un nuovo array numTrovati. 
                                            //Step by step appena ne trovo 2 ->messaggio di vincita  -- così via per le altre vincite


            //}
        }
    }
}
