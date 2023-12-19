/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package persistenciadefitxersjsonjackon;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import model.Book;
import model.Bookstore;
import model.Bookstore_Root;
import model.Title;

/**
 *
 * @author xavi
 */
public class Gson_In_Out {
    
    static String fnom = "src/resources/jj2.json";
    static String fnom2 = "src/resources/book1.json";

    // desserialització (fitxer a objectes) usant gson [POJOs de poc tamany]
    private static void gson_In(String fnom) throws IOException {
        // assumim fitxer json petit: llegim tot el fitxer en un string
        byte[] encoded = Files.readAllBytes(Paths.get(fnom));
        String json =new String(encoded, "UTF-8");

        Gson gson = new Gson();
        //utilitzem una classe root per a facilitar la lectura del node arrel
        Bookstore_Root e = new Bookstore_Root();
        //a partir del contingut del fitxer passat a string usant gson obtenim els objectes 
        e = gson.fromJson(json, Bookstore_Root.class);

        System.out.println(e.getBookstores());
    }

	// serialització (objectes a fitxer) usant gson [POJOs de poc tamany]
    private static void gson_Out(Bookstore e, String fnom) throws IOException  {
        File f = new File(fnom);
        FileWriter fw = new FileWriter(f);
        String json;

        //usem un GSonBuilder per a poder fer sortida "pretty"
        GsonBuilder gsonBuilder = new GsonBuilder();
        Gson prettyGson = gsonBuilder.setPrettyPrinting().create();

        //obtenim la clau externa del json i hi afegim el contingut
        JsonElement je = prettyGson.toJsonTree(e);
        JsonObject jo = new JsonObject();
        jo.add("bookstore", je);  

        //obtenim el json formatat en un string
        json = prettyGson.toJson(jo);

        //escrivim el json formatat en el fitxer escollit
        fw.write(json);
        fw.close();
    }

    public static void main(String[] args) throws IOException {
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
        System.out.println("----- Fitxers json amb gson ----------------");
        System.out.println("============================================");

        System.out.println("--- creant fitxer " + fnom + "-----------------");
        gson_Out(bs, fnom);
        System.out.println("---------- fitxer " + fnom + " creat ----------\n");

        // unmarshalling d'un altre fitxer
        System.out.println("--- llegint fitxer " + fnom2 + "-----------------");
        gson_In(fnom2);
    }
    
}
