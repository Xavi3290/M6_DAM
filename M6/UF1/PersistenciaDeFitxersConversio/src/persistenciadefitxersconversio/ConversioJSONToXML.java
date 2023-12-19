/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package persistenciadefitxersconversio;

import de.odysseus.staxon.json.JsonXMLConfig;
import de.odysseus.staxon.json.JsonXMLConfigBuilder;
import de.odysseus.staxon.json.JsonXMLInputFactory;
import de.odysseus.staxon.xml.util.PrettyXMLStreamWriter;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
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
public class ConversioJSONToXML {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws XMLStreamException, TransformerConfigurationException, TransformerException, IOException {
        // TODO code application logic here
        
        String nomFitxer = "book1_V2.xml";  // Fitxer on vull que es guardi el json
        File fit = new File(nomFitxer); 
        
        InputStream input = ConversioJSONToXML.class.getResourceAsStream("book1.json");  // Meterlo en xml o json en el misma carpeta que el ConversioXMLToJSON de la build/classes/ElNombreDeLaCarpetaQueHayasPueso
		OutputStream output = new FileOutputStream(fit);
		/*
		 * If the <code>multiplePI</code> property is
		 * set to <code>true</code>, the StAXON reader will generate
		 * <code>&lt;xml-multiple&gt;</code> processing instructions
		 * which would be copied to the XML output.
		 * These can be used by StAXON when converting back to JSON
		 * to trigger array starts.
		 * Set to <code>false</code> if you don't need to go back to JSON.
		 */
		JsonXMLConfig config = new JsonXMLConfigBuilder().multiplePI(false).build();
		try {
			/*
			 * Create source (JSON).
			 */
			XMLStreamReader reader = new JsonXMLInputFactory(config).createXMLStreamReader(input);
			Source source = new StAXSource(reader);
			
			/*
			 * Create result (XML).
			 */
			XMLStreamWriter writer = XMLOutputFactory.newInstance().createXMLStreamWriter(output);
			Result result = new StAXResult(new PrettyXMLStreamWriter(writer)); // format output
			
			/*
			 * Copy source to result via "identity transform".
			 */
			TransformerFactory.newInstance().newTransformer().transform(source, result);
		} finally {
			/*
			 * As per StAX specification, XMLStreamReader/Writer.close() doesn't close
			 * the underlying stream.
			 */
			output.close();
			input.close();
		}
        
    }
    
}
