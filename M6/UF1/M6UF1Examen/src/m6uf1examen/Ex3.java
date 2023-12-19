/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package m6uf1examen;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Marshaller;
import jakarta.xml.bind.Unmarshaller;
import java.io.File;
import model.Biographies;

/**
 *
 * @author xavi
 */
public class Ex3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
         try {
 
	    File file = new File("src/resources/x.xml");
		JAXBContext jaxbContext = JAXBContext.newInstance(Biographies.class);
                
                Marshaller jaxbMarshaller = jaxbContext.createMarshaller();                
                jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
 
		Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
		Biographies biographies = (Biographies) jaxbUnmarshaller.unmarshal(file);
		System.out.println(biographies);
 
	  } catch (JAXBException e) {
		e.printStackTrace();
	  }
    }
    
}
