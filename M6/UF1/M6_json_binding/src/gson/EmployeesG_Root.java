package gson;

import com.google.gson.annotations.SerializedName;

public class EmployeesG_Root {
	@SerializedName("employees")
	private EmployeesG employees;

	public EmployeesG getEmployees() {
		return employees;
	}

	public void setEmployees(EmployeesG employees) {
		this.employees = employees;
	}
}
