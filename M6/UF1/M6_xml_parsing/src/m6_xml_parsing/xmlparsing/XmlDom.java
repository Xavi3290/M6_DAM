package m6_xml_parsing.xmlparsing;

import java.util.ArrayList;
import java.util.List;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class XmlDom {
    public static void main(String[] args) throws Exception {
        //Creem la DOM Builder Factory
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();

        //Creem el DOM Builder
        DocumentBuilder builder = factory.newDocumentBuilder();

        //Load & Parse del document XML
        //document contindrà el XML complet en forma d'arbre
        Document document = builder.parse(ClassLoader.getSystemResourceAsStream("resources/comparEmployee.xml"));
          // Atenció ERROR: el fitxer ha d'estar a [eclipse: <package>/bin; NetBeans: <project>/build/classes]

        //en aquesta llista hi anirem posant els objectes employee que anem construint i carregant del xml 
        List<Employee> empList = new ArrayList<>();

        //Recorrent l'arbre n'extraiem les dades
        NodeList nodeList = document.getDocumentElement().getChildNodes();

        for (int i = 0; i < nodeList.getLength(); i++) {

            //Per a cada node <employee>,
            Node node = nodeList.item(i);
            if (node instanceof Element) {
                //creem un nou objecte
                Employee emp = new Employee();
                //assignem l'id a la propietat del nou objecte (està guardat com a atribut del node)
                emp.id = node.getAttributes().getNamedItem("id").getNodeValue();

                //childNodes contindrà la resta de propietats del employee (estan guardades com a nodes)
                NodeList childNodes = node.getChildNodes();
                for (int j = 0; j < childNodes.getLength(); j++) {
                    Node cNode = childNodes.item(j);

                    //Identifiquem el tag de cada fill del node employee i n'assignem el contingut a la propietat corresponent del nou objecte 
                    if (cNode instanceof Element) {
                        String content = cNode.getLastChild().
                                getTextContent().trim();
                        switch (cNode.getNodeName()) {
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
                }
                //afegim el nou objecte emplenat amb les dades del XML a la nostra llista d'objectes
                empList.add(emp);
            }
        }

        //Per a cada element de la nostra llista d'objectes employee, n'imprimim els valors
        for (Employee emp : empList) {
            System.out.println(emp);
        }

    }
}
