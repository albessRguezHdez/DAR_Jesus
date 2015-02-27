/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package FrontEnd;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.JTextPane;

import BackEnd.Scaneando;
import static javax.swing.JFrame.EXIT_ON_CLOSE;
/**
 *
 * @author jesus
public interface Ventana {
    
}
* 
*/

public class Ventana extends JFrame implements ActionListener{
    private JLabel mensajes,labelIP;
    private JTextPane areaTexto;
    private JButton buscar;
    private JTextField campoIP;
    private JScrollPane scroll;
    private JPanel panelSup;
    private Scaneando scan;
    
    public Ventana(){
        super("Scanneando en DAR (Y)");
        this.setBounds(0, 0, 600, 600);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        panelSup = new JPanel(new FlowLayout());
        labelIP = new JLabel("IP: ");
        campoIP = new JTextField(20);
        buscar = new JButton("Scannear");
        panelSup.add(labelIP);
        panelSup.add(campoIP);
        panelSup.add(buscar);
        this.add(panelSup,BorderLayout.NORTH);
        areaTexto = new JTextPane();
        areaTexto.setEditable(false);
        scroll = new JScrollPane(areaTexto);
        this.add(scroll,BorderLayout.CENTER);
        mensajes = new JLabel("Listo.");
        this.add(mensajes,BorderLayout.SOUTH);
        buscar.addActionListener(this);
        
        this.setVisible(true);
    }
    
    public JTextPane getAreaTexto(){
        return areaTexto;
    }
    
    public void setAreaTexto(JTextPane areaTexto){
        this.areaTexto = areaTexto;
    }
    
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==buscar){
            scan = new Scaneando(this);
        }
    }
    
    public JTextField getCampoIP(){
        return campoIP;
    }
    
    public void setCampoIP(JTextField campoIP){
        this.campoIP = campoIP;
    }
    
    public JLabel getMensajes(){
        return mensajes;
    }
    
    public void setMensajes(JLabel mensajes){
        this.mensajes = mensajes;
    }
    
    public JLabel getLabelIP(){
        return labelIP;
    }
    
    public void setLabelIP(JLabel labelIP){
        this.labelIP = labelIP;
    }
    
    public JButton getBuscar(){
        return buscar;
    }
    
    public void setBuscar(JButton buscar){
        this.buscar = buscar;
    }
    
}
