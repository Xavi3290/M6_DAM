/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersparsing;

import java.util.ArrayList;
import java.util.List;
import java.util.Set;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import model.Book;
import model.Title;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

/**
 *
 * @author xavi
 */
public class xmlDom {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws Exception {

        //Creem la DOM Builder Factory
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();

        //Creem el DOM Builder
        DocumentBuilder builder = factory.newDocumentBuilder();

        //Load & Parse del document XML
        //document contindrà el XML complet en forma d'arbre
        Document document = builder.parse(ClassLoader.getSystemResourceAsStream("resources/book1.xml"));
        // Atenció ERROR: el fitxer ha d'estar a [eclipse: <package>/bin; NetBeans: <project>/build/classes]

        //en aquesta llista hi anirem posant els objectes employee que anem construint i carregant del xml 
        List<Book> bookList = new ArrayList<>();

        //Recorrent l'arbre n'extraiem les dades
        NodeList nodeList = document.getDocumentElement().getChildNodes();

        for (int i = 0; i < nodeList.getLength(); i++) {

            //Per a cada node <employee>,
            Node node = nodeList.item(i);
            if (node instanceof Element) {
                //creem un nou objecte
                Book bo = new Book();
                Title ti = new Title();
                //assignem l'id a la propietat del nou objecte (està guardat com a atribut del node)
                bo.setCategory(node.getAttributes().getNamedItem("category").getNodeValue());

                //childNodes contindrà la resta de propietats del employee (estan guardades com a nodes)
                NodeList childNodes = node.getChildNodes();
                for (int j = 0; j < childNodes.getLength(); j++) {
                    Node cNode = childNodes.item(j);

                    //Identifiquem el tag de cada fill del node employee i n'assignem el contingut a la propietat corresponent del nou objecte 
                    if (cNode instanceof Element) {

                        String content = cNode.getLastChild().
                                getTextContent().trim();
                        switch (cNode.getNodeName()) {
                            case "title":
                                ti.setLang(cNode.getAttributes().getNamedItem("lang").getNodeValue());
                                ti.setTitle(content);
                                bo.setTitle(ti);
                                break;
                            case "author":
                                bo.setAuthor(content);
                                break;
                            case "year":
                                bo.setYear(Integer.parseInt(content));
                                break;
                            case "price":
                                bo.setPrice(Float.parseFloat(content));
                                break;
                        }
                    }
                }
                //afegim el nou objecte emplenat amb les dades del XML a la nostra llista d'objectes
                bookList.add(bo);
            }
        }

        //Per a cada element de la nostra llista d'objectes employee, n'imprimim els valors
        for (Book bo : bookList) {
            System.out.println(bo);
        }

    }

}
