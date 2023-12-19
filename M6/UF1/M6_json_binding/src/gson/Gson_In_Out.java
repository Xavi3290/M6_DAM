package gson;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import gson.Employee1G;
import gson.EmployeesG;
import gson.EmployeesG_Root;

public class Gson_In_Out {
    //fitxers amb què es treballarà
    static String fnom = "jj.json";
    static String fnom2 = "employees.json";

    // desserialització (fitxer a objectes) usant gson [POJOs de poc tamany]
    private static void gson_In(String fnom) throws IOException {
        // assumim fitxer json petit: llegim tot el fitxer en un string
        byte[] encoded = Files.readAllBytes(Paths.get(fnom));
        String json =new String(encoded, "UTF-8");

        Gson gson = new Gson();
        //utilitzem una classe root per a facilitar la lectura del node arrel
        EmployeesG_Root e = new EmployeesG_Root();
        //a partir del contingut del fitxer passat a string usant gson obtenim els objectes 
        e = gson.fromJson(json, EmployeesG_Root.class);

        System.out.println(e.getEmployees());
    }

	// serialització (objectes a fitxer) usant gson [POJOs de poc tamany]
    private static void gson_Out(EmployeesG e, String fnom) throws IOException  {
        File f = new File(fnom);
        FileWriter fw = new FileWriter(f);
        String json;

        //usem un GSonBuilder per a poder fer sortida "pretty"
        GsonBuilder gsonBuilder = new GsonBuilder();
        Gson prettyGson = gsonBuilder.setPrettyPrinting().create();

        //obtenim la clau externa del json i hi afegim el contingut
        JsonElement je = prettyGson.toJsonTree(e);
        JsonObject jo = new JsonObject();
        jo.add("employees", je);  

        //obtenim el json formatat en un string
        json = prettyGson.toJson(jo);

        //escrivim el json formatat en el fitxer escollit
        fw.write(json);
        fw.close();
    }

    public static void main(String[] args) throws IOException {
        //definició d'alguns objectes
        Employee1G employeeA = new Employee1G("1234", "Ferran", "Torrent", "València");
        Employee1G employeeB = new Employee1G("2345", "M Pau", "Janer", "Ciutat de Mallorca");
        Employee1G employeeC = new Employee1G("3456", "Joan Lluís", "Lluís", "Perpinyà");		

        //definició i càrrega de la llista
        EmployeesG employees = new EmployeesG();
        employees.add(employeeA);
        employees.add(employeeB);
        employees.add(employeeC);

        // marshalling
        System.out.println("----- Fitxers json amb gson ----------------");
        System.out.println("============================================");

        System.out.println("--- creant fitxer " + fnom + "-----------------");
        gson_Out(employees, fnom);
        System.out.println("---------- fitxer " + fnom + " creat ----------\n");

        // unmarshalling d'un altre fitxer
        System.out.println("--- llegint fitxer " + fnom2 + "-----------------");
        gson_In(fnom2);
    }
}
