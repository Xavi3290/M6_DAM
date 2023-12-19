/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxers;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.Scanner;
import static persistenciadefitxers.Ex03.llegirArxiuDeLineasCopia;

/**
 *
 * @author xavi
 */
public class Ex04 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner teclat = new Scanner(System.in);

        String nomFit = "vocab2.txt";
        File fitxer = new File(nomFit);
        //String nomCopia = "vocab2Cambiant.txt";
        //File fitxerCopia = new File(nomCopia);

        System.out.println("Posicio que vols cambiar: ");
        int swap1 = teclat.nextInt();
        System.out.println("Per aquesta: ");
        int swap2 = teclat.nextInt();

        DirectAccess(swap1, swap2, nomFit);
        //llegirArxiuDeLineasCopia(nomFit, nomCopia, swap1, swap2);
    }
    
     
    private static void DirectAccess(int swap1,int swap2, String nomFit) {
    RandomAccessFile file;
    try {
        
        file = new RandomAccessFile(nomFit,"rw");  //rw que puedes leer y escribir
        String saltoLinea = "\n";
        int numBytes = file.readLine().length() + saltoLinea.length();  // los bytes de la linea, lo calcula
        long pos1 = (swap1 - 1) * numBytes;
        long pos2 = (swap2 - 1) * numBytes;
        
        file.seek(pos1);
        String line=file.readLine();
        System.out.println(line);
        file.seek(pos2);
        String line2 = file.readLine();
        System.out.println(line2);
        
        file.seek(pos1);
        file.write(line2.getBytes());
        file.seek(pos2);
        file.write(line.getBytes());
       
        
        //System.out.println("read line: " + line);
        file.close();
    }
    catch (IOException e) {
        e.printStackTrace();
    }
}

    private static void writeUsingFileWriter(String data, String nomFit) {
        File file = new File(nomFit);
        FileWriter fr = null;
        try {
            fr = new FileWriter(file, true);
            fr.write(data + "\n");
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

    // De esta manera no se hace
    public static void llegirArxiuDeLineasCopia(String fnom, String nomCopia, int pos1, int pos2) {
        File fi = new File(fnom);
        Scanner lector = null;
        RandomAccessFile file;
        //RandomAccessFile file2;

        // System.out.printf("\nArxiu: %s\n", fi.getAbsoluteFile());
        try {
            lector = new Scanner(fi);
            int cont = 0;

            file = new RandomAccessFile(fnom, "r");
            //file2 = new RandomAccessFile(fnom, "r");
            file.seek(pos1);
            //file2.seek(pos2);
            String line = file.readLine();
            //String line2 = file2.readLine();
            // System.out.println("read line: " + line);
            file.close();

            while (lector.hasNext()) {
                String linea = lector.next();
                cont++;
                if (cont == pos1) {
                 //   writeUsingFileWriter(String.format("%6d;%-35s;%2d",pos2, line2, line2.length()), nomCopia);
                } else if (cont == pos2) {
                    writeUsingFileWriter(String.format("%6d;%-35s;%2d",pos1, line, line.length()), nomCopia);
                } else {
                    writeUsingFileWriter(String.format("%6d;%-35s;%2d", cont, linea, linea.length()), nomCopia);
                }

            }

        } catch (Exception e) {
            System.out.printf("Error: %s", e.toString());
        }
        if (lector != null) {
            lector.close();
        }
    }

}
