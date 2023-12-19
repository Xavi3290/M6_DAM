package xmlbinding;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Marshaller;
import java.io.File;

 
public class JaxbN_Out {
	public static void main(String[] args) {
 
	  Employee1 employeeA = new Employee1("1234", "Ferran", "Torrent", "València");
	  Employee1 employeeB = new Employee1("2345", "M Pau", "Janer", "Ciutat de Mallorca");
	  Employee1 employeeC = new Employee1("3456", "Joan Lluís", "Lluís", "Perpinyà");
	  Employees employees = new Employees();
	  employees.add(employeeA);
	  employees.add(employeeB);
	  employees.add(employeeC);
	  
	  System.out.println(employees);
	  System.out.println("-----------------");
	  
	  try {
 
		File file = new File("src/resources/JaxbN.xml");
		JAXBContext jaxbContext = JAXBContext.newInstance(Employees.class);
		Marshaller jaxbMarshaller = jaxbContext.createMarshaller();
 
		// output pretty printed
		jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
 
		jaxbMarshaller.marshal(employees, file);
		jaxbMarshaller.marshal(employees, System.out);
 
	  } catch (JAXBException e) {
		e.printStackTrace();
	  }
 	}
}

