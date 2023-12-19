/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package m6uf1examen;

import de.odysseus.staxon.json.JsonXMLConfig;
import de.odysseus.staxon.json.JsonXMLConfigBuilder;
import de.odysseus.staxon.json.JsonXMLInputFactory;
import de.odysseus.staxon.json.JsonXMLOutputFactory;
import de.odysseus.staxon.xml.util.PrettyXMLStreamWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import javax.xml.stream.XMLEventReader;
import javax.xml.stream.XMLEventWriter;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLOutputFactory;
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
public class Ex5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws FileNotFoundException, XMLStreamException, TransformerConfigurationException, TransformerException, IOException {

        String nomFitxer = "x.json";  // Fitxer on vull que es guardi el json
        File fit = new File(nomFitxer);        

        
    

        InputStream input = Ex5.class.getResourceAsStream("x.xml");  // Meterlo en xml to json en el misma carpeta que el ConversioXMLToJSON de la build/classes/ElNombreDeLaCarpetaQueHayasPueso
		
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
