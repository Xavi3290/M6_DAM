package gson;

import com.google.gson.annotations.SerializedName;

public class Employee1G {
    @SerializedName("-id")
    private String id;
    private String firstName;
    private String lastName;
    private String location;

    public Employee1G() {
    }

    public Employee1G(String id, String firstName, String lastName, String location) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.location = location;
    }

    public String getId() {
            return id;
    }

    public void setId(String id) {
            this.id = id;
    }

    public String getFirstName() {
            return firstName;
    }

    public void setFirstName(String firstName) {
            this.firstName = firstName;
    }

    public String getLastName() {
            return lastName;
    }

    public void setLastName(String lastName) {
            this.lastName = lastName;
    }

    public String getLocation() {
            return location;
    }

    public void setLocation(String location) {
            this.location = location;
    }

    @Override
    public String toString() {
            return "<"+firstName + " " + lastName + " [" + id + "] " + location + ">";
    }
}