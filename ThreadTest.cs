using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThreads // Note: actual namespace depends on the project name.
{
    public class ThreadTest
    {
        private int cpt; // var compteur
        public delegate void handler(int i); 
        
        public handler callback;

        public ThreadTest(int n){ // fonction ThreadTest
            cpt= n; // valeur du compteur : 12
        }

        public void ThreadLoop(){ // Boucle
            for(int i=0; i<cpt;i++){
                Thread.Sleep(500); // toutes les 500ms
                Console.WriteLine($"Je travaille ...{(i+1)}"); // on incrémete le compteur
                callback(i); // ?
            }
        }
        
    }
}