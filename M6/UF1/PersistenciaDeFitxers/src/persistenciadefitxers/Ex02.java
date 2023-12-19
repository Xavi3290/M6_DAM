/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxers;

import java.io.File;
import java.util.Scanner;

/**
 *
 * @author xavi
 */
public class Ex02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner teclat = new Scanner(System.in);
        
        String nomFit = "";
        
        System.out.println("Nom del fitxer a llegir: ");
        nomFit = teclat.nextLine();        
        
        llegirArxiuDeLineas(nomFit);
        
    }
    
    public static void llegirArxiuDeLineas(String fnom) {
        File fi = new File(fnom);
        Scanner lector = null;

       // System.out.printf("\nArxiu: %s\n", fi.getAbsoluteFile());
        try {
            lector = new Scanner(fi);
            while (lector.hasNext()) {
                String linea = lector.next();
                System.out.println(linea);
            }

        } catch (Exception e) {
            System.out.printf("Error: %s", e.toString());
        }
        if (lector != null) {
            lector.close();
        }
    }
    
}
