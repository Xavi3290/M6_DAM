/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package m6uf1examen;

import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import model.Awards;
import model.Biographies;
import model.Biography;

/**
 *
 * @author xavi
 */
public class Ex4 {

    static String fnom = "src/resources/x.json";
    //static String fnom2 = "src/resources/book1.json";
    //definició de variables necessàries
    static ObjectMapper mapper = new ObjectMapper();

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws JsonMappingException, IOException {

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

        Jackson_Out(bio, fnom);
        System.out.println("---------- fitxer " + fnom + " creat ----------\n");

    }

    private static void Jackson_Out(Object r, String fnom) throws JsonParseException, JsonMappingException, IOException {
        File f = new File(fnom);
        mapper.enable(SerializationFeature.INDENT_OUTPUT); //sortida "bonica"
        mapper.configure(SerializationFeature.WRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (a la serialització l'ha de posar)
        mapper.writeValue(f, r.getClass());
    }

}
