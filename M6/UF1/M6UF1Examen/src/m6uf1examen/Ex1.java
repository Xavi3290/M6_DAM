/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package m6uf1examen;

import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.RandomAccessFile;
import java.util.ArrayList;
import java.util.Scanner;
import model.Awards;
import model.Biographies;
import model.Biography;

/**
 *
 * @author xavi
 */
public class Ex1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner teclat = new Scanner(System.in);

        String text = "";

        System.out.println("Escriu un text (maxim 50 caràcters): ");
        text = teclat.nextLine();

        if (text.length() >= 50) {
            System.out.println("El text és mes gran que 50 caràcters");
            text = text.substring(0, 50);
        }

    }

//    private static void DirectAccess(int swap1, int swap2, String nomFit, String text) {
//        RandomAccessFile file;
//        try {
//
//            file = new RandomAccessFile(nomFit, "rw");  //rw que puedes leer y escribir
//            bytes b[] = text.getBytes();
//            //String saltoLinea = "\n";
//           // int numBytes = file.readLine().length();  // los bytes de la linea, lo calcula
//            //long pos1 = (swap1 - 1) * numBytes;
//            //long pos2 = (swap2 - 1) * numBytes;
//
//            file.seek(pos1);
//            String line = file.readLine();
//            System.out.println(line);
//            file.seek(pos2);
//            String line2 = file.readLine();
//            System.out.println(line2);
//
//            file.seek(pos1);
//            file.write(line2.getBytes());
//            file.seek(pos2);
//            file.write(line.getBytes());
//
//            //System.out.println("read line: " + line);
//            file.close();
//        } catch (IOException e) {
//            e.printStackTrace();
//        }
//    }
}
