/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package BackEnd;

import java.net.Socket;
import FrontEnd.Ventana;
/**
 *
 * @author jesus
 */
public class Scanner {
    public Scanner(int puerto,int fin,Ventana v){
        Socket dame;
        String ip=v.getCampoIP().getText();
        
            for(int port = puerto; port<=fin; port++){
                try{
                    dame = new Socket(ip,port);
                    v.getAreaTexto().setText(v.getAreaTexto().getText()+"\n"+"Puerto "+port+" Abierto");
                    //Muestra en interfaz el puerto abierto
                    System.out.println("Puerto "+port+" Abierto");
                    //Muestra el puerto que se encuentra abierto en consola
                    dame.close();
                }catch(Exception ex){
                    //
                }
            }
    }
}
