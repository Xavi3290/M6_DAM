package xmlbinding;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
import java.util.List;

@XmlRootElement(name = "employees")
public class Employees {
	@XmlElement(name = "employee")
	private List<Employee1> employees;

	public void setEmployees(List<Employee1> employees) {
		this.employees = employees;
	}

	public Employees getEmployees() {
		return (Employees) employees;
	}
	
	public void add(Employee1 employee) {
		if (this.employees == null) {
			this.employees = new ArrayList<Employee1>();
		}
		this.employees.add(employee);
	}

	@Override
	public String toString() {
		String s = "";
		for (Employee1 emp : employees)
			s = s + emp.toString() + "\n";
		return s;
	}
}