/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package BackEnd;

import FrontEnd.Ventana;
/**
 *
 * @author jesus
 */
public class Correr implements Runnable{
    int puerto=0;
    Ventana v;
    int fin;
    public Correr(int port,int fin,Ventana v){
    //public Correr(int port, Ventana v) //Error.
        this.v=v;
        puerto=port;
        this.fin=fin;
    }
    public void run(){
        Scanner Scanner = new Scanner(puerto,fin,v);
        //Scanner Scanner = new Scanner(puerto,v); //Error.
    }
}
