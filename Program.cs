using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThreads // Note: actual namespace depends on the project name.
{ //Les threads sont des exécutions que l'on sépare de l'exécution principale. C'est utile pour créer un certain parallélisme dans les exécutions
// Il s'agit de rendre des fonctions asynchrones
    public class Program
    {
        
        static int cpt=12; // var numérique ;
        public static void threadCallback(int i){
            if(cpt/2==i){ // Si j'arrive à la moitié du compteur
                Console.WriteLine("J'ai fais la moitié");
            }else if(i==cpt-1){ // et si j'arrive à la fin du compteur
                Console.WriteLine("J'ai fini!!!");
            }
        }

        public static void Main(string[] args)
        {
            ThreadTest myTest= new ThreadTest(cpt); // nouvelle instance de threadtest avec compteur
            myTest.callback += threadCallback; // ThreadTest compteur + threadCallback
            Thread thread= new Thread(new ThreadStart(myTest.ThreadLoop)); // Créer un thread pour exectuer la tâche
            thread.Start(); // Démarrer le thread
        }
    }
}