package conversiohtml;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.stream.StreamResult;
import javax.xml.transform.stream.StreamSource;

import com.thoughtworks.xstream.XStream;
import java.util.ArrayList;
import java.util.List;


public class ConversioHTML
{
	// a) A partir d'una llista d'objectes, crea un fichero XML usant la llibreria XStream.
	public static void ListToXMLWithXStream(String[] args) throws IOException, ClassNotFoundException
	{
		List<Departament> llistaDepartaments = new ArrayList<>();
                llistaDepartaments.add(new Departament(1, "Disseny", "Girona"));
		llistaDepartaments.add(new Departament(2, "Vendes", "Barcelona"));
		llistaDepartaments.add(new Departament(3, "Desenvolupament", "Granollers"));
		llistaDepartaments.add(new Departament(4, "Administració", "Manresa"));

		try
		{
			XStream xstream = new XStream();
			xstream.alias("departaments", List.class);
			xstream.alias("departament", Departament.class);
			xstream.toXML(llistaDepartaments, new FileOutputStream(new File(args[0])));
		}
		catch( Exception e )
		{
			e.printStackTrace();
		}
	}

	// b) Partint d'una plantilla XSL per a donar una presentació al fitxer XML generat a l'apartat a), fes un programa Java per a transformar-lo en HTML.
	public static void XMLAndXSLToHTML(String[] args) throws FileNotFoundException 
	{
		Source sXML = new StreamSource(new File(args[0])); //XML
		Source sXSL = new StreamSource(new File(args[1])); // XSL
		Result rHTML = new StreamResult(new FileOutputStream(new File(args[2]))); //HTML

		try
		{
			Transformer transformer = TransformerFactory.newInstance().newTransformer(sXSL);
			transformer.transform(sXML, rHTML);
		}
		catch( Exception e )
		{
			e.printStackTrace();
		}
	}


	public static void main(String[] args) throws IOException, ClassNotFoundException
	{

		String[] params = { "departaments.xml", "departaments.xsl", "departaments.html" };

		//A:
		ListToXMLWithXStream(params);

		//B:
		XMLAndXSLToHTML(params);
	}
}