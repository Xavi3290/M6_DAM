/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author xavi
 */
@XmlRootElement(name = "biographies")
public class Biographies {
    
    @XmlElement(name = "biography")
    private List<Biography> biographies;

    public Biographies getBiographies() {
        return (Biographies) biographies;
    }

    public void setBiographies(List<Biography> biographies) {
        this.biographies = biographies;
    }

    public void add(Biography biography) {
        if (this.biographies == null) {
            this.biographies = new ArrayList<Biography>();
        }
        this.biographies.add(biography);
    }
    

    @Override
    public String toString() {
        String s = "";
        for (Biography bo : biographies) {
            s = s + bo.toString() + "\n";
        }
        return s;
    }
    
   
}
