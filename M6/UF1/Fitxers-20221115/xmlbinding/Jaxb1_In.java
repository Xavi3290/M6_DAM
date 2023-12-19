package xmlbinding;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Unmarshaller;
import java.io.File;

 
public class Jaxb1_In {
	public static void main(String[] args) {
 
	 try {
 
		File file = new File("src/resources/Jaxb1.xml");
		JAXBContext jaxbContext = JAXBContext.newInstance(Employee1.class);
 
		Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
		Employee1 employee = (Employee1) jaxbUnmarshaller.unmarshal(file);
		System.out.println(employee);
 
	  } catch (JAXBException e) {
		e.printStackTrace();
	  }
 
	}
}