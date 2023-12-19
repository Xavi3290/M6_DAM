package jackson;

import java.util.ArrayList;
import java.util.List;

import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonRootName;

@JsonRootName("employees")
public class EmployeesJ {
	
	private List<Employee1J> employees;

	@JsonProperty("employee")
	public void setEmployees(List<Employee1J> employees) {
		this.employees = employees;
	}

	public List<Employee1J> getEmployees() {
		return employees;
	}

	public void add(Employee1J employee) {
		if (this.employees == null) {
			this.employees = new ArrayList<Employee1J>();
		}
		this.employees.add(employee);
	}

	@Override
	public String toString() {
		String s = "";
		for (Employee1J emp : employees)
			s = s + emp.toString() + "\n";
		return s;
	}
}
