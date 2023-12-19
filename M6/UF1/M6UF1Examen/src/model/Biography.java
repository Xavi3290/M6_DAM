/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import jakarta.xml.bind.annotation.XmlAttribute;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author xavi
 */
@XmlRootElement(name = "biography")
public class Biography {
    
    int id;
    String firstname;
    String lastname;           
    int birthYear;
    int deathYear;    
    String contribs1;
    String contribs2;
    String contribs3;
    String contribs4;
    Awards awards;

    public Biography() {
    }

    public Biography(int id, String firstname, String lastname, int birthYear, int deathYear, String contribs1, String contribs2, String contribs3, String contribs4, Awards awards) {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthYear = birthYear;
        this.deathYear = deathYear;
        this.contribs1 = contribs1;
        this.contribs2 = contribs2;
        this.contribs3 = contribs3;
        this.contribs4 = contribs4;
        this.awards = awards;
    }

    public Biography(int id, String firstname, String lastname, int birthYear, int deathYear, String contribs1, String contribs2, String contribs3, String contribs4) {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthYear = birthYear;
        this.deathYear = deathYear;
        this.contribs1 = contribs1;
        this.contribs2 = contribs2;
        this.contribs3 = contribs3;
        this.contribs4 = contribs4;
    }
    
    

    public int getId() {
        return id;
    }
    @XmlAttribute
    public void setId(int id) {
        this.id = id;
    }
    
    public String getFirstname() {
        return firstname;
    }
    @XmlAttribute
    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    public String getLastname() {
        return lastname;
    }
    @XmlAttribute
    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public int getBirthYear() {
        return birthYear;
    }

    public void setBirthYear(int birthYear) {
        this.birthYear = birthYear;
    }

    public int getDeathYear() {
        return deathYear;
    }

    public void setDeathYear(int deathYear) {
        this.deathYear = deathYear;
    }

    public String getContribs1() {
        return contribs1;
    }
    @XmlElement(name = "contribs")
    public void setContribs1(String contribs1) {
        this.contribs1 = contribs1;
    }

    public String getContribs2() {
        return contribs2;
    }
    @XmlElement(name = "contribs")
    public void setContribs2(String contribs2) {
        this.contribs2 = contribs2;
    }

    public String getContribs3() {
        return contribs3;
    }
    @XmlElement(name = "contribs")
    public void setContribs3(String contribs3) {
        this.contribs3 = contribs3;
    }

    public String getContribs4() {
        return contribs4;
    }
    @XmlElement(name = "contribs")
    public void setContribs4(String contribs4) {
        this.contribs4 = contribs4;
    }

    public Awards getAwards() {
        return awards;
    }

    public void setAwards(Awards awards) {
        this.awards = awards;
    }

    @Override
    public String toString() {
        return "Biography{" + "id=" + id + ", firstname=" + firstname + ", lastname=" + lastname + ", birthYear=" + birthYear + ", deathYear=" + deathYear + ", contribs1=" + contribs1 + ", contribs2=" + contribs2 + ", contribs3=" + contribs3 + ", contribs4=" + contribs4 + ", awards=" + awards + '}';
    }

   
    
    
    
}
