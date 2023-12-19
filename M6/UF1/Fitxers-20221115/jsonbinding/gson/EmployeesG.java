package gson;

import java.util.ArrayList;
import java.util.List;

import com.google.gson.annotations.SerializedName;

public class EmployeesG {
	@SerializedName("employee")
	private List<Employee1G> employees;

	public void setEmployees(List<Employee1G> employees) {
		this.employees = employees;
	}

	public List<Employee1G> getEmployees() {
		return employees;
	}

	public void add(Employee1G employee) {
		if (this.employees == null) {
			this.employees = new ArrayList<Employee1G>();
		}
		this.employees.add(employee);
	}

	@Override
	public String toString() {
		String s = "";
		for (Employee1G emp : employees)
			s = s + emp.toString() + "\n";
		return s;
	}
}
