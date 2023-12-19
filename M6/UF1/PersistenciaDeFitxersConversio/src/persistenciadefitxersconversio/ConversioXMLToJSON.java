/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersconversio;

import de.odysseus.staxon.json.JsonXMLConfig;
import de.odysseus.staxon.json.JsonXMLConfigBuilder;
import de.odysseus.staxon.json.JsonXMLOutputFactory;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import javax.xml.stream.XMLEventReader;
import javax.xml.stream.XMLEventWriter;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.XMLStreamReader;
import javax.xml.stream.XMLStreamWriter;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.stax.StAXResult;
import javax.xml.transform.stax.StAXSource;

/**
 *
 * @author xavi
 */
public class ConversioXMLToJSON {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws XMLStreamException, TransformerConfigurationException, TransformerException, IOException {
        // TODO code application logic here

//        InputStream input = ConversioXMLToJSON.class.getResourceAsStream("book1.xml");   // Meterlo en xml en el misma carpeta que el ConversioXMLToJSON de la build/classes/ElNombreDeLaCarpetaQueHayasPueso
//        OutputStream output = System.out;
//        /*
//		 * If we want to insert JSON array boundaries for multiple elements,
//		 * we need to set the <code>autoArray</code> property.
//		 * If our XML source was decorated with <code>&lt;?xml-multiple?&gt;</code>
//		 * processing instructions, we'd set the <code>multiplePI</code>
//		 * property instead.
//		 * With the <code>autoPrimitive</code> property set, element text gets
//		 * automatically converted to JSON primitives (number, boolean, null).
//         */
//        JsonXMLConfig config = new JsonXMLConfigBuilder()
//                .autoArray(true)
//                .autoPrimitive(true)
//                .prettyPrint(true)
//                .build();
//        try {
//            /*
//			 * Create source (XML).
//             */
//            XMLStreamReader reader = XMLInputFactory.newInstance().createXMLStreamReader(input);
//            Source source = new StAXSource(reader);
//
//            /*
//			 * Create result (JSON).
//             */
//            XMLStreamWriter writer = new JsonXMLOutputFactory(config).createXMLStreamWriter(output);
//            Result result = new StAXResult(writer);
//
//            /*
//			 * Copy source to result via "identity transform".
//             */
//            TransformerFactory.newInstance().newTransformer().transform(source, result);
//        } finally {
//            /*
//			 * As per StAX specification, XMLStreamReader/Writer.close() doesn't close
//			 * the underlying stream.
//             */
//            try {
//                output.close();
//                input.close();
//            } catch (Exception e) {
//                System.out.println(e.toString());
//            }
//        }

// Hay dos maneras de hacerlo

        String nomFitxer = "book1.json";  // Fitxer on vull que es guardi el json
        File fit = new File(nomFitxer);        

        
    

        InputStream input = ConversioXMLToJSON.class.getResourceAsStream("book1.xml");  // Meterlo en xml to json en el misma carpeta que el ConversioXMLToJSON de la build/classes/ElNombreDeLaCarpetaQueHayasPueso
		
        //OutputStream output = System.out;   // para que salga por consola
        OutputStream output = new FileOutputStream(fit);
                
		/*
		 * If we want to insert JSON array boundaries for multiple elements,
		 * we need to set the <code>autoArray</code> property.
		 * If our XML source was decorated with <code>&lt;?xml-multiple?&gt;</code>
		 * processing instructions, we'd set the <code>multiplePI</code>
		 * property instead.
		 * With the <code>autoPrimitive</code> property set, element text gets
		 * automatically converted to JSON primitives (number, boolean, null).
		 */
		      JsonXMLConfig config = new JsonXMLConfigBuilder()
                            // .virtualRoot("hola")
                .autoArray(true)
                .autoPrimitive(true)
                .prettyPrint(true)                              
                .build();
        try {
            /*
			 * Create reader (XML).
             */
            XMLEventReader reader = XMLInputFactory.newInstance().createXMLEventReader(input);

            /*
			 * Create writer (JSON).
             */
            XMLEventWriter writer = new JsonXMLOutputFactory(config).createXMLEventWriter(output);

            /*
			 * Copy events from reader to writer.
             */
            writer.add(reader);

            /*
			 * Close reader/writer.
             */
            reader.close();
            writer.close();
        } finally {
            /*
			 * As per StAX specification, XMLEventReader/Writer.close() doesn't close
			 * the underlying stream.
             */
            output.close();
            input.close();
        }
        

    }

}
