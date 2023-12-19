/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxers;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;
import java.io.PrintStream;
import java.util.Scanner;

/**
 *
 * @author xavi
 */
public class Ex01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner teclat = new Scanner(System.in);

        String nomFit = "";

        System.out.println("Nom del fitxer: ");
        nomFit = teclat.nextLine();

        File fitxer = new File(nomFit);

        if (fitxer.exists()) {
            System.out.println("Fitxer existeix");
            writeUsingFileWriterAppend(nomFit);
        } else {
            System.out.println("S'ha creat un nou fitxer");
            writeUsingFileWriter(nomFit);
        }

    }

    private static void writeUsingFileWriter(String nomFit) {    
        Scanner teclat = new Scanner(System.in);

        File file = new File(nomFit);
        FileWriter fr = null;
        String paraula = "";
        try {
            fr = new FileWriter(file);
            do {
                System.out.println("Posa una paraula: ");
                paraula = teclat.nextLine();
                if (!paraula.equals("the end")) {
                    fr.write(paraula + "\n");
                }
            } while (!paraula.equals("the end"));

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
    
    private static void writeUsingFileWriterAppend(String nomFit) {   // afegeix sense sobrescriure
        Scanner teclat = new Scanner(System.in);

        File file = new File(nomFit);
        FileWriter fr = null;
        String paraula = "";
        try {
            fr = new FileWriter(file,true);
            do {
                System.out.println("Posa una paraula: ");
                paraula = teclat.nextLine();
                if (!paraula.equals("the end")) {
                    fr.write(paraula + "\n");
                }
            } while (!paraula.equals("the end"));

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
    

}
