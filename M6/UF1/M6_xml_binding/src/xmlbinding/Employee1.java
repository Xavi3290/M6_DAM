package xmlbinding;

import jakarta.xml.bind.annotation.XmlAttribute;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement( name = "employee" )
public class Employee1 {
	private String id;
	private String firstName;
	private String lastName;
	private String location;
	
	public String getId() {
		return id;
	}

	@XmlAttribute
	public void setId(String id) {
		this.id = id;
	}

	public String getFirstName() {
		return firstName;
	}

        @XmlElement
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	@XmlElement
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getLocation() {
		return location;
	}

	@XmlElement
	public void setLocation(String location) {
		this.location = location;
	}
	
	public Employee1() {
	};
	
	public Employee1(String id, String firstName, String lastName, String location) {
		this.id=id;
		this.firstName=firstName;
		this.lastName=lastName;
		this.location=location;
	}

	@Override
	public String toString() {
		return firstName + " " + lastName + " [" + id + "] " + location;
	}
}