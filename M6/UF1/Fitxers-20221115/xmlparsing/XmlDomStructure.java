package xmlparsers;


import java.util.ArrayList;
import java.util.List;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class XmlDomStructure {
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

        printNodeList(nodeList, 0);
    }

    
    private static void printNodeList(NodeList nodeList, int n) {
        for (int i = 0; i < nodeList.getLength(); i++) {
            Node node = nodeList.item(i);
            if (node.hasChildNodes()) {
                for (int j=0; j<n; j++) {
                    System.out.printf("\t");
                }
                System.out.printf("Node %d - tipus:%s - nom:%s--> %s\n", 
                    i, node.getNodeType(), node.getNodeName(), node.getTextContent().trim());
                //Per a cada node que es correspongui a un objecte:

                if (node.getNodeName()!="#text") {
                    NodeList cNodeList = node.getChildNodes();
                    printNodeList(cNodeList, n+1);
                }
            }
        }
    }
}
