/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxers;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

/**
 *
 * @author xavi
 */
public class Ex03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        String nomFit = "vocab.txt";
        File fitxer = new File(nomFit);
        String nomCopia = "vocab2.txt";
        File fitxerCopia = new File(nomCopia);
        
        llegirArxiuDeLineasCopia(nomFit, nomCopia);

    }

    
    // con el buffer solo has de poner el br = new BufferedWriter(fr); i que escriba el br.write
    private static void FileWriterConBuffer(String data, String nomFit) {
        File file = new File(nomFit);
        FileWriter fr = null;
        BufferedWriter br = null;
        try {
            fr = new FileWriter(file,true);
            br = new BufferedWriter(fr);
            br.write(data+"\n");
          //  fr.write("\n");
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                fr.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
    
   

    
    public static void llegirArxiuDeLineasCopia(String fnom, String nomCopia) {
        File fi = new File(fnom);
        Scanner lector = null;       
        

       // System.out.printf("\nArxiu: %s\n", fi.getAbsoluteFile());
        try {
            lector = new Scanner(fi);
            int cont = 0;
            while (lector.hasNext()) {
                String linea = lector.next();
                cont++;
                FileWriterConBuffer(String.format("%6d;%-35s;%2d",cont,linea, linea.length()),nomCopia);
                
            }

        } catch (Exception e) {
            System.out.printf("Error: %s", e.toString());
        }
        if (lector != null) {
            lector.close();
        }
    }

}
