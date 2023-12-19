/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import jakarta.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author xavi
 */
@XmlRootElement( name = "awards" )
public class Awards {
    
    String award;
    int year;
    String by;

    public Awards() {
    }

    public Awards(String award, int year, String by) {
        this.award = award;
        this.year = year;
        this.by = by;
    }

    public String getAward() {
        return award;
    }

    public void setAward(String award) {
        this.award = award;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public String getBy() {
        return by;
    }

    public void setBy(String by) {
        this.by = by;
    }

    @Override
    public String toString() {
        return "Awards{" + "award=" + award + ", year=" + year + ", by=" + by + '}';
    }
    
    
}
