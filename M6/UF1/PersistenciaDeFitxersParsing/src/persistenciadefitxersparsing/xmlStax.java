/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersparsing;

import java.util.ArrayList;
import java.util.List;
import java.util.Set;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamConstants;
import javax.xml.stream.XMLStreamReader;
import model.Book;
import model.Title;

/**
 *
 * @author xavi
 */
public class xmlStax {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws Exception {

        List<Book> bookList = null;
        Book currBo = null;
        Title currTi = null;
        String tagContent = null;

        //creem la XML factory
        XMLInputFactory factory = XMLInputFactory.newInstance();
        //creem el XML reader
        XMLStreamReader reader = factory.createXMLStreamReader(ClassLoader.getSystemResourceAsStream("resources/book1.xml"));
        // Atenció ERROR: el fitxer ha d'estar a [eclipse: <package>/bin; NetBeans: <project>/build/classes]

        //cal anar gestionant els elements trobats al XML mentre n'hi hagi
        while (reader.hasNext()) {
            //localitzem el proper event
            int event = reader.next();

            //ens podem trobar tres tipus de events: start, characters, end
            switch (event) {
                case XMLStreamConstants.START_ELEMENT:
                    //si comença un nou element, creem l'objecte i li assignem l'id 
                    if ("book".equals(reader.getLocalName())) {
                        currBo = new Book();
                        currBo.setCategory(reader.getAttributeValue(0));
                    }
                    if ("title".equals(reader.getLocalName())) {
                        currTi = new Title();
                        currTi.setLang(reader.getAttributeValue(0));
                    }
                    //a l'inici, quan comencen els elements creem una llista d'objectes employee on hi anirem afegint els employees trobats al XML
                    if ("bookstore".equals(reader.getLocalName())) {
                        bookList = new ArrayList<>();
                    }
                    break;

                //quan ens trobem caràcters, els copiem a la variable intermèdia de contingut
                case XMLStreamConstants.CHARACTERS:
                    tagContent = reader.getText().trim();
                    break;

                case XMLStreamConstants.END_ELEMENT:
                    switch (reader.getLocalName()) {
                        //Si s'acaba un node employee, afegim l'objecte a la llista (ja tenim les dades de l'objecte carregades)
                        case "book":
                            bookList.add(currBo);
                            break;
                        //Quan trobem tags de final de nodes de propietats, assignem el corresponent valor a la propietat que toqui del nou objecte
                        case "title":
                            currTi.setTitle(tagContent);
                            currBo.setTitle(currTi);
                            break;
                        case "author":
                            currBo.setAuthor(tagContent);                            
                            break;
                        case "year":
                            currBo.setYear(Integer.parseInt(tagContent));                            
                            break;
                        case "price":
                            currBo.setPrice(Float.parseFloat(tagContent));  
                            break;
                    }
                    break;

                case XMLStreamConstants.START_DOCUMENT:
                    ////alternativament, podríem crear la llista d'objectes aquí en comptes de quan llegim l'obertura del node employees
                    ////a la pràctica, però, en aquest cas no funciona
                    //
                    //empList = new ArrayList<>();
                    break;
            }

        }

        //Imprimim la llista d'employees trobada al XML
        for (Book bo : bookList) {
            System.out.println(bo);
        }

    }

}
