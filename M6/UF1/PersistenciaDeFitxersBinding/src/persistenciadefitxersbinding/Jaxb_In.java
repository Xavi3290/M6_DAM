/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersbinding;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Marshaller;
import jakarta.xml.bind.Unmarshaller;
import java.io.File;
import model.Bookstore;

/**
 *
 * @author xavi
 */
public class Jaxb_In {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
         try {
 
	    File file = new File("src/resources/book1.xml");
		JAXBContext jaxbContext = JAXBContext.newInstance(Bookstore.class);
                
                Marshaller jaxbMarshaller = jaxbContext.createMarshaller();                
                jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
 
		Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
		Bookstore bookstore = (Bookstore) jaxbUnmarshaller.unmarshal(file);
		System.out.println(bookstore);
 
	  } catch (JAXBException e) {
		e.printStackTrace();
	  }
    }
    
}
