/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package persistenciadefitxersjsonjackon;

import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;
import java.io.File;
import java.io.IOException;
import model.Book;
import model.Bookstore;
import model.Title;

/**
 *
 * @author xavi
 */
public class Jackson_In_Out {
   
     //fitxers amb què es treballarà

    static String fnom = "src/resources/jj.json";
    static String fnom2 = "src/resources/book1.json";
    //definició de variables necessàries
    static ObjectMapper mapper = new ObjectMapper();

    // unmarshalling (fitxer a objectes) usant Jackson
    // A i B
//    private static void Jackson_In(String fnom) throws JsonParseException, JsonMappingException, IOException {
//        File f = new File(fnom);
//        mapper.configure(DeserializationFeature.UNWRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (se'l trobarà a la deserialització)
//        Bookstore e = mapper.readValue(f, Bookstore.class);
//        System.out.println(e);
//    }
    
    // C
    private static void Jackson_In(String fnom) throws JsonParseException, JsonMappingException, IOException {
        File f = new File(fnom);
        mapper.configure(DeserializationFeature.UNWRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (se'l trobarà a la deserialització)
        Bookstore e = mapper.readValue(f, Bookstore.class);
        System.out.println(e);
    }

    //   A i B
    // marshalling (objectes a fitxer) usant Jackson   
//    private static void Jackson_Out(Bookstore r, String fnom) throws JsonParseException, JsonMappingException, IOException {
//        File f = new File(fnom);
//        mapper.enable(SerializationFeature.INDENT_OUTPUT); //sortida "bonica"
//        mapper.configure(SerializationFeature.WRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (a la serialització l'ha de posar)
//        mapper.writeValue(f, r);
//    }
    
    // C
    private static void Jackson_Out(Object r, String fnom) throws JsonParseException, JsonMappingException, IOException {   
        File f = new File(fnom);
        mapper.enable(SerializationFeature.INDENT_OUTPUT); //sortida "bonica"
        mapper.configure(SerializationFeature.WRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (a la serialització l'ha de posar)
        mapper.writeValue(f, r.getClass());
    }

    public static void main(String[] args) throws JsonParseException, JsonMappingException, IOException {
        //definició d'alguns objectes
        Title t = new Title("lang1","text1");
        Title t2 = new Title("lang2","text2");
        
        Book b1 = new Book("category1",t,"author1",1,1f);
        Book b2 = new Book("category2",t2,"author2",2,2.2f);
        
         //definició i càrrega de la llista
        Bookstore bs = new Bookstore();
        bs.add(b1);
        bs.add(b2);

       

        // marshalling 
        System.out.println("----- Fitxers json amb Jackson ----------------");
        System.out.println("===============================================");

        System.out.println("--- creant fitxer " + fnom + "-----------------");
        Jackson_Out(bs, fnom);
        System.out.println("---------- fitxer " + fnom + " creat ----------\n");

        // unmarshalling d'un altre fitxer
        System.out.println("--- llegint fitxer " + fnom2 + "-----------------");
        Jackson_In(fnom2);
    }
    
}
