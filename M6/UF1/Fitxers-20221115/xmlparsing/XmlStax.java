package xmlparsers;

import java.util.ArrayList;
import java.util.List;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamConstants;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.XMLStreamReader;

public class XmlStax {
  public static void main(String[] args) throws XMLStreamException {
	List<Employee> empList = null;
    Employee currEmp = null;
    String tagContent = null;
    
    //creem la XML factory
    XMLInputFactory factory = XMLInputFactory.newInstance();
    //creem el XML reader
    XMLStreamReader reader = factory.createXMLStreamReader(ClassLoader.getSystemResourceAsStream("resources/comparEmployee.xml")); 
      // Atenció ERROR: el fitxer ha d'estar a [eclipse: <package>/bin; NetBeans: <project>/build/classes]

    //cal anar gestionant els elements trobats al XML mentre n'hi hagi
    while(reader.hasNext()){
      //localitzem el proper event
      int event = reader.next();

      //ens podem trobar tres tipus de events: start, characters, end
      switch(event){
        case XMLStreamConstants.START_ELEMENT: 
          //si comença un nou element, creem l'objecte i li assignem l'id 
          if ("employee".equals(reader.getLocalName())){
            currEmp = new Employee();
            currEmp.id = reader.getAttributeValue(0);
          }
          //a l'inici, quan comencen els elements creem una llista d'objectes employee on hi anirem afegint els employees trobats al XML
          if("employees".equals(reader.getLocalName())){
            empList = new ArrayList<>();
          }
          break;

        //quan ens trobem caràcters, els copiem a la variable intermèdia de contingut
        case XMLStreamConstants.CHARACTERS:
          tagContent = reader.getText().trim();
          break;

        
        case XMLStreamConstants.END_ELEMENT:
          switch(reader.getLocalName()){
            //Si s'acaba un node employee, afegim l'objecte a la llista (ja tenim les dades de l'objecte carregades)
            case "employee":
              empList.add(currEmp);
              break;
            //Quan trobem tags de final de nodes de propietats, assignem el corresponent valor a la propietat que toqui del nou objecte
            case "firstName":
              currEmp.firstName = tagContent;
              break;
            case "lastName":
              currEmp.lastName = tagContent;
              break;
            case "location":
              currEmp.location = tagContent;
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
    for ( Employee emp : empList){
      System.out.println(emp);
    }

  }
}

