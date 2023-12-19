package xmlbinding;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Marshaller;
import java.io.File;
 
public class Jaxb1_Out {
	public static void main(String[] args) {
 
	  Employee1 employee = new Employee1("0123", "Joan", "Fuster", "València");
	   
	  try {
 
		File file = new File("src/resources/Jaxb1.xml");
		JAXBContext jaxbContext = JAXBContext.newInstance(Employee1.class);
		Marshaller jaxbMarshaller = jaxbContext.createMarshaller();
 
		// output pretty printed
		jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
 
		jaxbMarshaller.marshal(employee, file);
		jaxbMarshaller.marshal(employee, System.out);
 
	  } catch (JAXBException e) {
		e.printStackTrace();
	  }
 	}
}