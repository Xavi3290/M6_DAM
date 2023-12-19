/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersbinding;

import jakarta.xml.bind.JAXBContext;
import jakarta.xml.bind.JAXBException;
import jakarta.xml.bind.Marshaller;
import java.io.File;
import model.Book;
import model.Bookstore;
import model.Title;

/**
 *
 * @author xavi
 */
public class Jaxb_Out {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Bookstore bs = new Bookstore();
        Title t1 = new Title("lang1", "title1");
        Book b1 = new Book("category1", t1, "autor1", 1, 1f);
        Title t2 = new Title("lang2", "title2");
        Book b2 = new Book("category2", t2, "autor2", 2, 2f);
        Title t3 = new Title("lang3", "title3");
        Book b3 = new Book("category3", t3, "autor3", 3, 3f);
        Title t4 = new Title("lang4", "title4");
        Book b4 = new Book("category4", t3, "autor4", 4, 4f);
        bs.add(b1);
        bs.add(b2);
        bs.add(b3);
        bs.add(b4);

        try {

            File file = new File("src/resources/Llibres.xml");
            JAXBContext jaxbContext = JAXBContext.newInstance(Bookstore.class);
            Marshaller jaxbMarshaller = jaxbContext.createMarshaller();

            // output pretty printed
            jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

            jaxbMarshaller.marshal(bs, file);
            jaxbMarshaller.marshal(bs, System.out);

        } catch (JAXBException e) {
            e.printStackTrace();
        }
    }
}
