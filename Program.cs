using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThreads // Note: actual namespace depends on the project name.
{
    public class Program
    {
        
        static int cpt=12; // Boucle jusque 12;
        public static void threadCallback(int i){
            if(cpt/2==i){ // Si j'arrive à la moitié du compteur
                Console.WriteLine("J'ai fais la moitié");
            }else if(i==cpt-1){ // Si j'arrive à la fin du compteur
                Console.WriteLine("J'ai fini!!!");
            }
        }

        public static void Main(string[] args)
        {
            ThreadTest myTest= new ThreadTest(cpt); // nouvelle instance de thread
            myTest.callback += threadCallback; // fonction ThreadTest + fonction ThreadCallback
            Thread thread= new Thread(new ThreadStart(myTest.ThreadLoop)); // on déclare un thread qu'on appelle thread. On crée un new Thread, avec en param le thread qu'on a créé au dessus, qui prend lui-même en param le nom du thread test créé précédemment et la fonction qui permet de faire la boucle
            thread.Start(); // On démarre le thread
        }
    }
}