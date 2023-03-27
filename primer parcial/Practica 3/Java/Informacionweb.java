//package Practicas.Java.Practica3;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.net.*;

public class Informacionweb extends JFrame implements ActionListener {

    public Informacionweb() {
        this.setSize(450, 350);//asigno el tamaño a la ventana
        this.setLocationRelativeTo(null);//Le asigno un posicion inicial
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);//Asigno una operacion por default
        this.setTitle("Practica_3");//Le asigno un titulo
        init();
        this.setVisible(true);//La hago visible

        aceptar.addActionListener(this);
        limpiar.addActionListener(this);
        ayuda.addActionListener(this);
    }

    public void init() {        
        addPanels();
        addLabels();
        addTextFields();
        addTextAreas();
        addButtons();
    }

    public void addPanels(){
        this.setLayout(new BorderLayout());//le asigno un layuout a la ventana
        P_superior= new JPanel();//Creo los paneles que voy a usar
        P_superior.setLayout(new BorderLayout());//Y les asigno un layaout igual
        

        P_central= new JPanel();
        P_central.setLayout(new BorderLayout());
        
            
        P_inferior = new JPanel();
        P_inferior.setLayout(new BorderLayout());

        this.add(P_superior, BorderLayout.NORTH);//luego añado los paneles, al layout de la ventana.
        this.add(P_central, BorderLayout.CENTER);
        this.add(P_inferior, BorderLayout.SOUTH);           
    }

    //Metodo donde añado las etiquetas
    public void addLabels(){
        direccion = new JLabel("Introduzca la direcion web: ");
        direccion.setBackground(Color.GRAY);
        direccion.setForeground(Color.BLUE);
        P_superior.add(direccion, BorderLayout.WEST);
    }

    //Metodo donde añado los campo de texto
    public void addTextFields(){
        text = new JTextField();
        P_superior.add(text, BorderLayout.CENTER);
    }

    //Metodo donde añado las areas de texto
    public void addTextAreas(){
        txt_out = new JTextArea();
        txt_out.setEditable(false);
        P_central.add(txt_out, BorderLayout.CENTER);    
    }

    //Metodo donde añado los botones
    public void addButtons(){
        aceptar = new JButton("Aceptar");
        aceptar.setBackground(Color.DARK_GRAY);
        aceptar.setForeground(Color.WHITE);
        P_superior.add(aceptar, BorderLayout.EAST);

        limpiar = new JButton("Limpiar");
        limpiar.setBackground(Color.RED);
        limpiar.setForeground(Color.WHITE);
        P_inferior.add(limpiar, BorderLayout.WEST);

        ayuda = new JButton("Ayuda");
        ayuda.setBackground(Color.BLACK);
        ayuda.setForeground(Color.WHITE);
        P_inferior.add(ayuda, BorderLayout.EAST);

    }


    @Override
    public void actionPerformed(ActionEvent e) {
        Object buttonPressed = e.getSource();

        //Si se presiona aceptar obtengo los datos
        if (buttonPressed == aceptar) {
            try {
                String url = text.getText();
                InetAddress ip = InetAddress.getByName(url);
                txt_out.setText("La direccion IP es: \n" + ip.getHostAddress());
               
            } catch (Exception error) {
                // TODO: handle exception
            }
        }

        //Si se presiona limpiar se limpia todo, tanto el area de texto como el campo de texo
        if (buttonPressed == limpiar) {
            txt_out.setText("");
            text.setText("");
        }

        //Si se presiona ayuda, entonces se muestra un mensaje con la informacion para poder ingresar una url validad
        if (buttonPressed == ayuda) {
            txt_out.setText("");
            txt_out.append("Cuando introduzca la direccion web, considere lo siguiente: \n Se escribe a partir del www. , aqui un ejemplo: www.google.com.mx"+
            "\nNo introduzca: https, http.\nTampoco tiene que tener espacios y tampoco comas\n.");
        }
    }

    public static void main(String[] args) {
        new Informacionweb();
    }

    private JTextField text;
    private JLabel direccion;
    private JTextArea txt_out;
    private JButton aceptar;
    private JButton limpiar;
    private JButton ayuda;
    private JPanel P_superior;
    private JPanel P_central;
    private JPanel P_inferior;

}
