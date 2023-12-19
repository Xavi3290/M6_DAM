package xmlparsers;

import java.util.ArrayList;
import java.util.List;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class XmlSax {

  public static void main(String[] args) throws Exception {
    //Creem la SAX parser factory
	SAXParserFactory parserFactor = SAXParserFactory.newInstance();
	//Creem el SAX builder 
    SAXParser parser = parserFactor.newSAXParser();
    //Creem el SAX handler (extensió nostra del Default SAX handler)
    SAXHandler handler = new SAXHandler();
    //el parsing el fem utilitzant el nostre handler
    parser.parse(ClassLoader.getSystemResourceAsStream("resources/comparEmployee.xml"),
                 handler);
      // Atenció ERROR: el fitxer ha d'estar a [eclipse: <package>/bin; NetBeans: <project>/build/classes]

    //Imprimim la llista d'employees trobada al XML
    for ( Employee emp : handler.empList){
      System.out.println(emp);
    }
  }
}
/**
 * El nostre SAX handler, extensió del Default
 */
class SAXHandler extends DefaultHandler {

  //creem una llista d'objectes employee on hi anirem afegint els employees trobats al XML
  List<Employee> empList = new ArrayList<>();
  Employee emp = null;
  String content = null;
  
  @Override
  //Es dispara quan es troba un inici d'element (tag StartElement)
  public void startElement(String uri, String localName, String qName, Attributes attributes) 
                           throws SAXException {

    switch(qName){
      //Quan trobem un tag Start, creem un nou employee (i li assignem l'id trobat a l'atribut del node)
      case "employee":
        emp = new Employee();
        emp.id = attributes.getValue("id");
        break;
    }
  }

  
  @Override
  //Es dispara quan es troba un final d'element (tag EndElement)
  public void endElement(String uri, String localName, String qName) throws SAXException {
   switch(qName){
     //Si s'acaba un node employee, afegim l'objecte a la llista (ja tenim les dades de l'objecte carregades)
     case "employee":
       empList.add(emp);       
       break;
     //Quan trobem tags de final de nodes de propietats, assignem el corresponent valor a la propietat que toqui del nou objecte 
     case "firstName":
       emp.firstName = content;
       break;
     case "lastName":
       emp.lastName = content;
       break;
     case "location":
       emp.location = content;
       break;
   }
  }

  //mentre anem trobant caràcters, els copiem a la variable intermèdia de contingut
  @Override
  public void characters(char[] ch, int start, int length) 
          throws SAXException {
    content = String.copyValueOf(ch, start, length).trim();
  }

}

