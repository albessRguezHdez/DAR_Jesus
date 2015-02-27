/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package BackEnd;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

import FrontEnd.Ventana;
/**
 *
 * @author jesus
 */
public class Scaneando {
    
    private Ventana v;
    
    public Scaneando(Ventana v){
        this.v=v;
        v.getBuscar().setEnabled(false);
        v.getCampoIP().setEditable(false);
        ExecutorService executor = Executors.newCachedThreadPool();
            int ini=1,fin=100;
            //int cont=1;//error.
            //el condicional para escanear del puerto 1 al puerto 65500, corriendo un hilo por cada
            //puerto que se encuentra abierto, manda a llamar a Correr
            while(fin<=65500){
                //executor.execute(new Correr(cont,v)); //error.
                executor.execute(new Correr(ini,fin,v));
                //cont=ini; //error.
                fin+=100;
                ini+=100;
            }
            //executor.execute(new Correr(65501,v)); //error.
            executor.execute(new Correr(65501,65535,v));
    }
}
