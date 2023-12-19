package xmlbinding;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Unmarshaller;
import java.io.File;

public class JaxbN_In {
	public static void main(String[] args) {
 
	 try {
 
	    File file = new File("src/resources/JaxbN.xml");
		JAXBContext jaxbContext = JAXBContext.newInstance(Employees.class);
 
		Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
		Employees employees = (Employees) jaxbUnmarshaller.unmarshal(file);
		System.out.println(employees);
 
	  } catch (JAXBException e) {
		e.printStackTrace();
	  }
 
	}
}