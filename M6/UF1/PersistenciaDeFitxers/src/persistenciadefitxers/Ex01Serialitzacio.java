/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxers;

import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;

/**
 *
 * @author xavi
 */
public class Ex01Serialitzacio {

    /**
     * @param args the command line arguments
     */
     

    public static void main(String[] args) {

        String nomFitxer = "Persones.ser";
        File fit = new File(nomFitxer);
        
        ArrayList<Persona> persones = new ArrayList<Persona>();
        ArrayList<Persona> persones2 = new ArrayList<Persona>();

        Persona per = new Persona("Xavi", "Roca", "Perez", 31, "Trinitat Falguera nº11");
        Persona per2 = new Persona("Xavi2", "Roca2", "Perez2", 32, "Trinitat Falguera nº12");
        Persona per3 = new Persona("Xavi3", "Roca3", "Perez3", 33, "Trinitat Falguera nº13");

        persones.add(per);
        persones.add(per2);
        persones.add(per3);

        for (Persona pe : persones) {
            System.out.println(pe.toString());
        }

        guardarPersones(persones, fit);

        System.out.println("\nSegona part\n");
        
        persones2 = cargarPersones(nomFitxer);
        
        for (Persona pe : persones2) {
            System.out.println(pe.toString());
        }

    }

    public static void guardarPersones(ArrayList persones, File fit) {
        try {
            FileOutputStream fos = new FileOutputStream(fit);
            ObjectOutputStream oos = new ObjectOutputStream(fos);

            oos.writeObject(persones);
            oos.close();

        } catch (Exception e) {
            System.out.println(e.toString());
        }

    }

    public static ArrayList<Persona> cargarPersones(String nFitxer) {
        ArrayList<Persona> persones = null;
        ObjectInputStream ois = null;
        try {
            FileInputStream fis = new FileInputStream(nFitxer);
            ois = new ObjectInputStream(fis);
            while (true) {
                persones = (ArrayList<Persona>) ois.readObject();
                persones.toString();

            }
        } catch (EOFException exc) {
            System.out.println("\n**************** FIN ARXIU**************\n");
        } catch (Exception io) {
            System.out.println(io.toString());
        } finally {
            try {
                if (ois != null) {
                    ois.close();
                }
            } catch (IOException e) {
                System.out.println(e.toString());
            }
        }
        return persones;
    }
}
