/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersparsing;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;
import model.Book;
import model.Title;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

/**
 *
 * @author xavi
 */
public class xmlSax {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws Exception {
        //Creem la SAX parser factory
        SAXParserFactory parserFactor = SAXParserFactory.newInstance();
        //Creem el SAX builder 
        SAXParser parser = parserFactor.newSAXParser();
        //Creem el SAX handler (extensió nostra del Default SAX handler)
        SAXHandler handler = new SAXHandler();
        //el parsing el fem utilitzant el nostre handler
        parser.parse(ClassLoader.getSystemResourceAsStream("resources/book1.xml"),
                handler);
        // Atenció ERROR: el fitxer ha d'estar a [eclipse: <package>/bin; NetBeans: <project>/build/classes]

        //Imprimim la llista d'employees trobada al XML
        for (Book bo : handler.bookList) {
            System.out.println(bo);
        }
    }
}

/**
 * El nostre SAX handler, extensió del Default
 */
class SAXHandler extends DefaultHandler {

    //creem una llista d'objectes employee on hi anirem afegint els employees trobats al XML
    List<Book> bookList = new ArrayList<>();
    Book bo = null;
    Title ti = null;
    String content = null;

    @Override
    //Es dispara quan es troba un inici d'element (tag StartElement)
    public void startElement(String uri, String localName, String qName, Attributes attributes)
            throws SAXException {

        switch (qName) {
            //Quan trobem un tag Start, creem un nou employee (i li assignem l'id trobat a l'atribut del node)
            case "book":
                bo = new Book();
                bo.setCategory(attributes.getValue("category"));
                break;
            case "title":
                ti = new Title();
                ti.setLang(attributes.getValue("lang"));    // me falla aqui puede ser que tenga que hacer un new Title
        }
    }

    @Override
    //Es dispara quan es troba un final d'element (tag EndElement)
    public void endElement(String uri, String localName, String qName) throws SAXException {
        switch (qName) {
            //Si s'acaba un node employee, afegim l'objecte a la llista (ja tenim les dades de l'objecte carregades)
            case "book":
                bookList.add(bo);
                break;
            //Quan trobem tags de final de nodes de propietats, assignem el corresponent valor a la propietat que toqui del nou objecte 
            case "author":
                bo.setAuthor(content);
                break;
            case "year":
                bo.setYear(Integer.parseInt(content));
                break;
            case "price":
                bo.setPrice(Float.parseFloat(content));
                break;
            case "title":
                ti.setTitle(content);
                bo.setTitle(ti);

        }
    }

    //mentre anem trobant caràcters, els copiem a la variable intermèdia de contingut
    @Override
    public void characters(char[] ch, int start, int length)
            throws SAXException {
        content = String.copyValueOf(ch, start, length).trim();
    }

}
