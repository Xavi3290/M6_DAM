package jackson;

import java.io.File;
import java.io.IOException;


import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;
import com.fasterxml.jackson.databind.DeserializationFeature;

public class Jackson_In_Out {
	//fitxers amb què es treballarà
	static String fnom = "jj.json";
	static String fnom2 = "employees.json";
	//definició de variables necessàries
	static ObjectMapper mapper = new ObjectMapper();
	
	// unmarshalling (fitxer a objectes) usant Jackson
	private static void Jackson_In(String fnom) throws JsonParseException, JsonMappingException, IOException {
		File f = new File(fnom);
		mapper.configure(DeserializationFeature.UNWRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (se'l trobarà a la deserialització)
		EmployeesJ e = mapper.readValue(f, EmployeesJ.class);
		System.out.println(e);
	}

	// marshalling (objectes a fitxer) usant Jackson
	private static void Jackson_Out(EmployeesJ r, String fnom) throws JsonParseException, JsonMappingException, IOException  {
		File f = new File(fnom);
		mapper.enable(SerializationFeature.INDENT_OUTPUT); //sortida "bonica"
		mapper.configure(SerializationFeature.WRAP_ROOT_VALUE, true);  //Li diem que hi ha un node arrel (a la serialització l'ha de posar)
		mapper.writeValue(f, r);
	}

	public static void main(String[] args) throws JsonParseException, JsonMappingException, IOException {
		//definició d'alguns objectes
		Employee1J employeeA = new Employee1J("1234", "Ferran", "Torrent", "València");
		Employee1J employeeB = new Employee1J("2345", "M Pau", "Janer", "Ciutat de Mallorca");
		Employee1J employeeC = new Employee1J("3456", "Joan Lluís", "Lluís", "Perpinyà");
		
		//definició i càrrega de la llista
		EmployeesJ employees = new EmployeesJ();
		employees.add(employeeA);
		employees.add(employeeB);
		employees.add(employeeC);
		
		// marshalling 
		System.out.println("----- Fitxers json amb Jackson ----------------");
		System.out.println("===============================================");

		System.out.println("--- creant fitxer " + fnom + "-----------------");
		Jackson_Out(employees, fnom);
		System.out.println("---------- fitxer " + fnom + " creat ----------\n");
		
		// unmarshalling d'un altre fitxer
		System.out.println("--- llegint fitxer " + fnom2 + "-----------------");
		Jackson_In(fnom2);
	}

}

