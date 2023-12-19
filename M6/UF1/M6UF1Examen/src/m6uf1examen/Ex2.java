/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package m6uf1examen;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Marshaller;
import jakarta.xml.bind.Unmarshaller;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.List;
import model.Awards;
import model.Biographies;
import model.Biography;
import model.Contribs;

/**
 *
 * @author xavi
 */
public class Ex2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        String nomFitxer = "bio.ser";
        File fit = new File(nomFitxer);

        ArrayList<Biography> bio = new ArrayList<Biography>();
        ArrayList<Biography> bio2 = new ArrayList<Biography>();

        Biography biog = new Biography(1, "Xavi", "Roca", 1990, 2100, "contrib", "contrib", "contrib", "contrib");
        Biography biog2 = new Biography(2, "Xavi2", "Roca2", 1992, 2102, "contrib", "contrib", "contrib", "contrib");
        Biography biog3 = new Biography(3, "Xavi3", "Roca3", 1993, 2103, "contrib", "contrib", "contrib", "contrib");

        Awards aw = new Awards("Premi", 1, "by");
        Awards aw2 = new Awards("Premi2", 2, "by");
        Awards aw3 = new Awards("Premi3", 3, "by");

        biog.setAwards(aw);
        biog2.setAwards(aw2);
        biog3.setAwards(aw3);

        bio.add(biog);
        bio.add(biog2);
        bio.add(biog3);

        for (Biography pe : bio) {
            System.out.println(pe.toString());
        }

        guardarBiographies(bio, fit);

        System.out.println("\nSegona part\n");

        bio2 = cargarBiographies(nomFitxer);

        for (Biography pe : bio2) {
            System.out.println(pe.toString());
        }

    }

    public static void guardarBiographies(ArrayList persones, File fit) {
        try {
            FileOutputStream fos = new FileOutputStream(fit);
            ObjectOutputStream oos = new ObjectOutputStream(fos);

            oos.writeObject(persones);
            oos.close();

        } catch (Exception e) {
            System.out.println(e.toString());
        }

    }

    public static ArrayList<Biography> cargarBiographies(String nFitxer) {
        ArrayList<Biography> persones = null;
        ObjectInputStream ois = null;
        try {
            FileInputStream fis = new FileInputStream(nFitxer);
            ois = new ObjectInputStream(fis);
            while (true) {
                persones = (ArrayList<Biography>) ois.readObject();
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
